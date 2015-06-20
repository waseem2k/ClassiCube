﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ClassicalSharp.Commands;

namespace ClassicalSharp.Plugin {
	
	public abstract class Plugin {
		
		public abstract string Name { get; }
		
		public abstract string Authors { get; }
		
		public abstract string Description { get; }
		
		public abstract IEnumerable<PluginModule> Modules { get; }
		
		public static void LoadPlugin( string file, Game game ) {
			Assembly assembly = Assembly.LoadFile( file );
			Type[] types = assembly.GetTypes();
			foreach( Type t in types ) {
				if( t.IsAbstract || t.IsInterface || t.IsGenericType ) continue;
				if( t.IsSubclassOf( typeof( Plugin ) ) ) {
					Plugin p = (Plugin)Activator.CreateInstance( t );
					Console.WriteLine( "Loading plugin: {0}, written by {1}", p.Name, p.Authors );
					Console.WriteLine( "Plugin description: {0}", p.Description );
					foreach( PluginModule module in p.Modules ) {
						HandleModule( module, game );
					}
				}
			}
		}
		
		static void HandleModule( PluginModule module, Game game ) {
			switch( module.ModuleType ) {
				case PluginModuleType.Command:
					Command cmd = (Command)Activator.CreateInstance( module.ImplementationType, game );
					game.CommandManager.RegisterCommand( cmd );
					break;
			}
		}
	}
	
	public enum PluginModuleType {
		EnvironmentRenderer,
		WeatherRenderer,
		Command,
	}
	
	public class PluginModule {
		
		public PluginModuleType ModuleType;
		
		public Type ImplementationType;
		
		public PluginModule( PluginModuleType moduleType, Type implementation ) {
			ModuleType = moduleType;
			ImplementationType = implementation;
		}
	}
}
