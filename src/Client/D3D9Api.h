#ifndef CS_D3D9API_H
#define CS_D3D9API_H
#include <d3d9.h>
#include <d3d9caps.h>
#include <d3d9types.h>

/* Abstracts Direct3D9 3D graphics rendering API.
   Copyright 2014-2017 ClassicalSharp | Licensed under BSD-3
*/

/* Maximum number of matrices that go on a stack. */
#define MatrixStack_Capacity 24

typedef struct MatrixStack {

	/* Raw array of matrices.*/
	Matrix Stack[MatrixStack_Capacity];

	/* Current active matrix. */
	Int32 Index;

	/* Type of transformation this stack is for. */
	D3DTRANSFORMSTATETYPE TransformType;
} MatrixStack;

D3DPRIMITIVETYPE d3d9_modeMappings[2] = { D3DPT_TRIANGLELIST, D3DPT_LINELIST };
D3DFORMAT d3d9_depthFormats[6] = { D3DFMT_D32, D3DFMT_D24X8, D3DFMT_D24S8, D3DFMT_D24X4S4, D3DFMT_D16, D3DFMT_D15S1 };
D3DFORMAT d3d9_viewFormats[4] = { D3DFMT_X8R8G8B8, D3DFMT_R8G8B8, D3DFMT_R5G6B5, D3DFMT_X1R5G5B5 };
D3DBLEND d3d9_blendFuncs[6] = { D3DBLEND_ZERO, D3DBLEND_ONE, D3DBLEND_SRCALPHA, D3DBLEND_INVSRCALPHA, D3DBLEND_DESTALPHA, D3DBLEND_INVDESTALPHA };
D3DCMPFUNC d3d9_compareFuncs[8] = { D3DCMP_ALWAYS, D3DCMP_NOTEQUAL, D3DCMP_NEVER, D3DCMP_LESS, D3DCMP_LESSEQUAL, D3DCMP_EQUAL, D3DCMP_GREATEREQUAL, D3DCMP_GREATER };
D3DFOGMODE d3d9_modes[3] = { D3DFOG_LINEAR, D3DFOG_EXP, D3DFOG_EXP2 };
Int32 d3d9_formatMappings[2] = { D3DFVF_XYZ | D3DFVF_DIFFUSE, D3DFVF_XYZ | D3DFVF_DIFFUSE | D3DFVF_TEX2 };

#endif