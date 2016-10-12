﻿// ClassicalSharp copyright 2014-2016 UnknownShadow200 | Licensed under MIT
using System;
using System.Collections.Generic;
using ClassicalSharp.GraphicsAPI;
using OpenTK;

namespace ClassicalSharp.Selections {
	
	public class SelectionManager : IGameComponent {
		
		protected Game game;
		IGraphicsApi gfx;
		VertexP3fC4b[] vertices, lineVertices;
		int vb, lineVb;
		
		public void Init( Game game ) {
			this.game = game;
			gfx = game.Graphics;
		}

		public void Ready( Game game ) { }			
		public void Reset( Game game ) { selections.Clear(); }
		public void OnNewMap( Game game ) { selections.Clear(); }
		public void OnNewMapLoaded( Game game ) { }
		
		List<SelectionBox> selections = new List<SelectionBox>( 256 );
		public void AddSelection( byte id, Vector3I p1, Vector3I p2, FastColour col ) {
			RemoveSelection( id );
			SelectionBox selection = new SelectionBox( p1, p2, col );
			selection.ID = id;
			selections.Add( selection );
		}
		
		public void RemoveSelection( byte id ) {
			for( int i = 0; i < selections.Count; i++ ) {
				SelectionBox sel = selections[i];
				if( sel.ID == id ) {
					selections.RemoveAt( i );
					break;
				}
			}
		}
		
		SelectionBoxComparer comparer = new SelectionBoxComparer();
		public void Render( double delta ) {
			if( selections.Count == 0 ) return;			
			
			// TODO: Proper selection box sorting. But this is very difficult because
			// we can have boxes within boxes, intersecting boxes, etc. Probably not worth it.
			Vector3 camPos = game.CurrentCameraPos;
			for( int i = 0; i < selections.Count; i++ )
				comparer.Intersect( selections[i], camPos );				
			selections.Sort( comparer );
			if( vertices == null )
				InitData(); // lazy init as most servers don't use this.
			
			int index = 0, lineIndex = 0;
			for( int i = 0; i < selections.Count; i++ ) {
				SelectionBox box = selections[i];
				box.Render( delta, vertices, lineVertices, ref index, ref lineIndex );
			}
			
			gfx.SetBatchFormat( VertexFormat.P3fC4b );
			gfx.UpdateDynamicVb( DrawMode.Lines, lineVb, lineVertices, selections.Count * LineVerticesCount );
			
			gfx.DepthWrite = false;
			gfx.AlphaBlending = true;
			gfx.UpdateDynamicIndexedVb( DrawMode.Triangles, vb, vertices,
			                                selections.Count * VerticesCount );
			gfx.DepthWrite = true;
			gfx.AlphaBlending = false;
		}
		
		public void Dispose() {			
			if( lineVb <= 0 ) return;
			gfx.DeleteDynamicVb( ref vb );
			gfx.DeleteDynamicVb( ref lineVb );
		}
		
		const int VerticesCount = 6 * 4, LineVerticesCount = 12 * 2;
		void InitData() {
			vertices = new VertexP3fC4b[256 * VerticesCount];
			lineVertices = new VertexP3fC4b[256 * LineVerticesCount];
			vb = gfx.CreateDynamicVb( VertexFormat.P3fC4b, vertices.Length );
			lineVb = gfx.CreateDynamicVb( VertexFormat.P3fC4b, lineVertices.Length );
		}
	}
}