﻿// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software",, to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//    Peter Bartok    pbartok@novell.com
//


// NOT COMPLETE

using System;
using System.Runtime.InteropServices;

// X11 Version
namespace OpenTK.Platform.X11
{
	//
	// In the structures below, fields of type long are mapped to IntPtr.
	// This will work on all platforms where sizeof(long)==sizeof(void*), which
	// is almost all platforms except WIN64.
	//

	[StructLayout(LayoutKind.Sequential)]
	public struct XAnyEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XKeyEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr root;
		public IntPtr subwindow;
		public IntPtr time;
		public int x;
		public int y;
		public int x_root;
		public int y_root;
		public int state;
		public int keycode;
		public bool same_screen;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XButtonEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr root;
		public IntPtr subwindow;
		public IntPtr time;
		public int x;
		public int y;
		public int x_root;
		public int y_root;
		public int state;
		public int button;
		public bool same_screen;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XMotionEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr root;
		public IntPtr subwindow;
		public IntPtr time;
		public int x;
		public int y;
		public int x_root;
		public int y_root;
		public int state;
		public byte is_hint;
		public bool same_screen;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XCrossingEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr root;
		public IntPtr subwindow;
		public IntPtr time;
		public int x;
		public int y;
		public int x_root;
		public int y_root;
		public NotifyMode mode;
		public NotifyDetail detail;
		public bool same_screen;
		public bool focus;
		public int state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XFocusChangeEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public int mode;
		public NotifyDetail detail;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XKeymapEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public byte key_vector0;
		public byte key_vector1;
		public byte key_vector2;
		public byte key_vector3;
		public byte key_vector4;
		public byte key_vector5;
		public byte key_vector6;
		public byte key_vector7;
		public byte key_vector8;
		public byte key_vector9;
		public byte key_vector10;
		public byte key_vector11;
		public byte key_vector12;
		public byte key_vector13;
		public byte key_vector14;
		public byte key_vector15;
		public byte key_vector16;
		public byte key_vector17;
		public byte key_vector18;
		public byte key_vector19;
		public byte key_vector20;
		public byte key_vector21;
		public byte key_vector22;
		public byte key_vector23;
		public byte key_vector24;
		public byte key_vector25;
		public byte key_vector26;
		public byte key_vector27;
		public byte key_vector28;
		public byte key_vector29;
		public byte key_vector30;
		public byte key_vector31;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XExposeEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public int x;
		public int y;
		public int width;
		public int height;
		public int count;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XGraphicsExposeEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr drawable;
		public int x;
		public int y;
		public int width;
		public int height;
		public int count;
		public int major_code;
		public int minor_code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XNoExposeEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr drawable;
		public int major_code;
		public int minor_code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XVisibilityEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public int state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XCreateWindowEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr parent;
		public IntPtr window;
		public int x;
		public int y;
		public int width;
		public int height;
		public int border_width;
		public bool override_redirect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XDestroyWindowEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XUnmapEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public bool from_configure;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XMapEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public bool override_redirect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XMapRequestEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr parent;
		public IntPtr window;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XReparentEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public IntPtr parent;
		public int x;
		public int y;
		public bool override_redirect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XConfigureEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public int x;
		public int y;
		public int width;
		public int height;
		public int border_width;
		public IntPtr above;
		public bool override_redirect;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XGravityEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public int x;
		public int y;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XResizeRequestEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public int width;
		public int height;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XConfigureRequestEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr parent;
		public IntPtr window;
		public int x;
		public int y;
		public int width;
		public int height;
		public int border_width;
		public IntPtr above;
		public int detail;
		public IntPtr value_mask;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XCirculateEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr xevent;
		public IntPtr window;
		public int place;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XCirculateRequestEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr parent;
		public IntPtr window;
		public int place;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XPropertyEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr atom;
		public IntPtr time;
		public int state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XSelectionClearEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr selection;
		public IntPtr time;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XSelectionRequestEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr owner;
		public IntPtr requestor;
		public IntPtr selection;
		public IntPtr target;
		public IntPtr property;
		public IntPtr time;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XSelectionEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr requestor;
		public IntPtr selection;
		public IntPtr target;
		public IntPtr property;
		public IntPtr time;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XColormapEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr colormap;
		public bool c_new;
		public int state;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XClientMessageEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public IntPtr message_type;
		public int format;
		public IntPtr ptr1;
		public IntPtr ptr2;
		public IntPtr ptr3;
		public IntPtr ptr4;
		public IntPtr ptr5;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XMappingEvent
	{
		public XEventName type;
		public IntPtr serial;
		public bool send_event;
		public IntPtr display;
		public IntPtr window;
		public int request;
		public int first_keycode;
		public int count;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XErrorEvent
	{
		public XEventName type;
		public IntPtr display;
		public IntPtr resourceid;
		public IntPtr serial;
		public byte error_code;
		public XRequest request_code;
		public byte minor_code;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XEventPad
	{
		public IntPtr pad0;
		public IntPtr pad1;
		public IntPtr pad2;
		public IntPtr pad3;
		public IntPtr pad4;
		public IntPtr pad5;
		public IntPtr pad6;
		public IntPtr pad7;
		public IntPtr pad8;
		public IntPtr pad9;
		public IntPtr pad10;
		public IntPtr pad11;
		public IntPtr pad12;
		public IntPtr pad13;
		public IntPtr pad14;
		public IntPtr pad15;
		public IntPtr pad16;
		public IntPtr pad17;
		public IntPtr pad18;
		public IntPtr pad19;
		public IntPtr pad20;
		public IntPtr pad21;
		public IntPtr pad22;
		public IntPtr pad23;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct XEvent
	{
		[FieldOffset(0)]
		public XEventName type;
		[FieldOffset(0)]
		public XAnyEvent AnyEvent;
		[FieldOffset(0)]
		public XKeyEvent KeyEvent;
		[FieldOffset(0)]
		public XButtonEvent ButtonEvent;
		[FieldOffset(0)]
		public XMotionEvent MotionEvent;
		[FieldOffset(0)]
		public XCrossingEvent CrossingEvent;
		[FieldOffset(0)]
		public XFocusChangeEvent FocusChangeEvent;
		[FieldOffset(0)]
		public XExposeEvent ExposeEvent;
		[FieldOffset(0)]
		public XGraphicsExposeEvent GraphicsExposeEvent;
		[FieldOffset(0)]
		public XNoExposeEvent NoExposeEvent;
		[FieldOffset(0)]
		public XVisibilityEvent VisibilityEvent;
		[FieldOffset(0)]
		public XCreateWindowEvent CreateWindowEvent;
		[FieldOffset(0)]
		public XDestroyWindowEvent DestroyWindowEvent;
		[FieldOffset(0)]
		public XUnmapEvent UnmapEvent;
		[FieldOffset(0)]
		public XMapEvent MapEvent;
		[FieldOffset(0)]
		public XMapRequestEvent MapRequestEvent;
		[FieldOffset(0)]
		public XReparentEvent ReparentEvent;
		[FieldOffset(0)]
		public XConfigureEvent ConfigureEvent;
		[FieldOffset(0)]
		public XGravityEvent GravityEvent;
		[FieldOffset(0)]
		public XResizeRequestEvent ResizeRequestEvent;
		[FieldOffset(0)]
		public XConfigureRequestEvent ConfigureRequestEvent;
		[FieldOffset(0)]
		public XCirculateEvent CirculateEvent;
		[FieldOffset(0)]
		public XCirculateRequestEvent CirculateRequestEvent;
		[FieldOffset(0)]
		public XPropertyEvent PropertyEvent;
		[FieldOffset(0)]
		public XSelectionClearEvent SelectionClearEvent;
		[FieldOffset(0)]
		public XSelectionRequestEvent SelectionRequestEvent;
		[FieldOffset(0)]
		public XSelectionEvent SelectionEvent;
		[FieldOffset(0)]
		public XColormapEvent ColormapEvent;
		[FieldOffset(0)]
		public XClientMessageEvent ClientMessageEvent;
		[FieldOffset(0)]
		public XMappingEvent MappingEvent;
		[FieldOffset(0)]
		public XErrorEvent ErrorEvent;
		[FieldOffset(0)]
		public XKeymapEvent KeymapEvent;

		//[MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=24)]
		//[ FieldOffset(0) ] public int[] pad;
		[FieldOffset(0)]
		public XEventPad Pad;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XSetWindowAttributes
	{
		public IntPtr background_pixmap;
		public IntPtr background_pixel;
		public IntPtr border_pixmap;
		public IntPtr border_pixel;
		public Gravity bit_gravity;
		public Gravity win_gravity;
		public int backing_store;
		public IntPtr backing_planes;
		public IntPtr backing_pixel;
		public bool save_under;
		public IntPtr event_mask;
		public IntPtr do_not_propagate_mask;
		public bool override_redirect;
		public IntPtr colormap;
		public IntPtr cursor;
	}

	public enum XEventName
	{
		KeyPress = 2,
		KeyRelease = 3,
		ButtonPress = 4,
		ButtonRelease = 5,
		MotionNotify = 6,
		EnterNotify = 7,
		LeaveNotify = 8,
		FocusIn = 9,
		FocusOut = 10,
		KeymapNotify = 11,
		Expose = 12,
		GraphicsExpose = 13,
		NoExpose = 14,
		VisibilityNotify = 15,
		CreateNotify = 16,
		DestroyNotify = 17,
		UnmapNotify = 18,
		MapNotify = 19,
		MapRequest = 20,
		ReparentNotify = 21,
		ConfigureNotify = 22,
		ConfigureRequest = 23,
		GravityNotify = 24,
		ResizeRequest = 25,
		CirculateNotify = 26,
		CirculateRequest = 27,
		PropertyNotify = 28,
		SelectionClear = 29,
		SelectionRequest = 30,
		SelectionNotify = 31,
		ColormapNotify = 32,
		ClientMessage = 33,
		MappingNotify = 34,

		LASTEvent
	}

	[Flags]
	public enum SetWindowValuemask
	{
		Nothing = 0,
		BackPixmap = 1,
		BackPixel = 2,
		BorderPixmap = 4,
		BorderPixel = 8,
		BitGravity = 16,
		WinGravity = 32,
		BackingStore = 64,
		BackingPlanes = 128,
		BackingPixel = 256,
		OverrideRedirect = 512,
		SaveUnder = 1024,
		EventMask = 2048,
		DontPropagate = 4096,
		ColorMap = 8192,
		Cursor = 16384
	}

	public enum CreateWindowArgs
	{
		CopyFromParent = 0,
		ParentRelative = 1,
		InputOutput = 1,
		InputOnly = 2
	}

	public enum Gravity
	{
		ForgetGravity = 0,
		NorthWestGravity = 1,
		NorthGravity = 2,
		NorthEastGravity = 3,
		WestGravity = 4,
		CenterGravity = 5,
		EastGravity = 6,
		SouthWestGravity = 7,
		SouthGravity = 8,
		SouthEastGravity = 9,
		StaticGravity = 10
	}

	#pragma warning disable 1591

	[Flags]
	public enum EventMask
	{
		NoEventMask = 0,
		KeyPressMask = 1 << 0,
		KeyReleaseMask = 1 << 1,
		ButtonPressMask = 1 << 2,
		ButtonReleaseMask = 1 << 3,
		EnterWindowMask = 1 << 4,
		LeaveWindowMask = 1 << 5,
		PointerMotionMask = 1 << 6,
		PointerMotionHintMask = 1 << 7,
		Button1MotionMask = 1 << 8,
		Button2MotionMask = 1 << 9,
		Button3MotionMask = 1 << 10,
		Button4MotionMask = 1 << 11,
		Button5MotionMask = 1 << 12,
		ButtonMotionMask = 1 << 13,
		KeymapStateMask = 1 << 14,
		ExposureMask = 1 << 15,
		VisibilityChangeMask = 1 << 16,
		StructureNotifyMask = 1 << 17,
		ResizeRedirectMask = 1 << 18,
		SubstructureNotifyMask = 1 << 19,
		SubstructureRedirectMask = 1 << 20,
		FocusChangeMask = 1 << 21,
		PropertyChangeMask = 1 << 22,
		ColormapChangeMask = 1 << 23,
		OwnerGrabButtonMask = 1 << 24
	}

	#pragma warning restore 1591

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct XColor
	{
		public IntPtr pixel;
		public ushort red;
		public ushort green;
		public ushort blue;
		public byte flags;
		public byte pad;
	}

	public enum Atom
	{
		AnyPropertyType = 0,
		XA_PRIMARY = 1,
		XA_SECONDARY = 2,
		XA_ARC = 3,
		XA_ATOM = 4,
		XA_BITMAP = 5,
		XA_CARDINAL = 6,
		XA_COLORMAP = 7,
		XA_CURSOR = 8,
		XA_CUT_BUFFER0 = 9,
		XA_CUT_BUFFER1 = 10,
		XA_CUT_BUFFER2 = 11,
		XA_CUT_BUFFER3 = 12,
		XA_CUT_BUFFER4 = 13,
		XA_CUT_BUFFER5 = 14,
		XA_CUT_BUFFER6 = 15,
		XA_CUT_BUFFER7 = 16,
		XA_DRAWABLE = 17,
		XA_FONT = 18,
		XA_INTEGER = 19,
		XA_PIXMAP = 20,
		XA_POINT = 21,
		XA_RECTANGLE = 22,
		XA_RESOURCE_MANAGER = 23,
		XA_RGB_COLOR_MAP = 24,
		XA_RGB_BEST_MAP = 25,
		XA_RGB_BLUE_MAP = 26,
		XA_RGB_DEFAULT_MAP = 27,
		XA_RGB_GRAY_MAP = 28,
		XA_RGB_GREEN_MAP = 29,
		XA_RGB_RED_MAP = 30,
		XA_STRING = 31,
		XA_VISUALID = 32,
		XA_WINDOW = 33,
		XA_WM_COMMAND = 34,
		XA_WM_HINTS = 35,
		XA_WM_CLIENT_MACHINE = 36,
		XA_WM_ICON_NAME = 37,
		XA_WM_ICON_SIZE = 38,
		XA_WM_NAME = 39,
		XA_WM_NORMAL_HINTS = 40,
		XA_WM_SIZE_HINTS = 41,
		XA_WM_ZOOM_HINTS = 42,
		XA_MIN_SPACE = 43,
		XA_NORM_SPACE = 44,
		XA_MAX_SPACE = 45,
		XA_END_SPACE = 46,
		XA_SUPERSCRIPT_X = 47,
		XA_SUPERSCRIPT_Y = 48,
		XA_SUBSCRIPT_X = 49,
		XA_SUBSCRIPT_Y = 50,
		XA_UNDERLINE_POSITION = 51,
		XA_UNDERLINE_THICKNESS = 52,
		XA_STRIKEOUT_ASCENT = 53,
		XA_STRIKEOUT_DESCENT = 54,
		XA_ITALIC_ANGLE = 55,
		XA_X_HEIGHT = 56,
		XA_QUAD_WIDTH = 57,
		XA_WEIGHT = 58,
		XA_POINT_SIZE = 59,
		XA_RESOLUTION = 60,
		XA_COPYRIGHT = 61,
		XA_NOTICE = 62,
		XA_FONT_NAME = 63,
		XA_FAMILY_NAME = 64,
		XA_FULL_NAME = 65,
		XA_CAP_HEIGHT = 66,
		XA_WM_CLASS = 67,
		XA_WM_TRANSIENT_FOR = 68,

		XA_LAST_PREDEFINED = 68
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XScreen
	{
		public IntPtr ext_data;
		public IntPtr display;
		public IntPtr root;
		public int width;
		public int height;
		public int mwidth;
		public int mheight;
		public int ndepths;
		public IntPtr depths;
		public int root_depth;
		public IntPtr root_visual;
		public IntPtr default_gc;
		public IntPtr cmap;
		public IntPtr white_pixel;
		public IntPtr black_pixel;
		public int max_maps;
		public int min_maps;
		public int backing_store;
		public bool save_unders;
		public IntPtr root_input_mask;
	}

	[Flags]
	public enum ChangeWindowAttributes
	{
		X = 1 << 0,
		Y = 1 << 1,
		Width = 1 << 2,
		Height = 1 << 3,
		BorderWidth = 1 << 4,
		Sibling = 1 << 5,
		StackMode = 1 << 6,
	}

	public enum StackMode
	{
		Above = 0,
		Below = 1,
		TopIf = 2,
		BottomIf = 3,
		Opposite = 4
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XWindowChanges
	{
		public int x;
		public int y;
		public int width;
		public int height;
		public int border_width;
		public IntPtr sibling;
		public StackMode stack_mode;
	}

	[Flags]
	public enum ColorFlags
	{
		DoRed = 1 << 0,
		DoGreen = 1 << 1,
		DoBlue = 1 << 2
	}

	public enum NotifyMode
	{
		NotifyNormal = 0,
		NotifyGrab = 1,
		NotifyUngrab = 2
	}

	public enum NotifyDetail
	{
		NotifyAncestor = 0,
		NotifyVirtual = 1,
		NotifyInferior = 2,
		NotifyNonlinear = 3,
		NotifyNonlinearVirtual = 4,
		NotifyPointer = 5,
		NotifyPointerRoot = 6,
		NotifyDetailNone = 7
	}

	[Flags]
	public enum KeyMasks
	{
		ShiftMask = (1 << 0),
		LockMask = (1 << 1),
		ControlMask = (1 << 2),
		Mod1Mask = (1 << 3),
		Mod2Mask = (1 << 4),
		Mod3Mask = (1 << 5),
		Mod4Mask = (1 << 6),
		Mod5Mask = (1 << 7),

		ModMasks = Mod1Mask | Mod2Mask | Mod3Mask | Mod4Mask | Mod5Mask
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XModifierKeymap
	{
		public int max_keypermod;
		public IntPtr modifiermap;
	}

	public enum PropertyMode
	{
		Replace = 0,
		Prepend = 1,
		Append = 2
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XKeyBoardState
	{
		public int key_click_percent;
		public int bell_percent;
		public uint bell_pitch, bell_duration;
		public IntPtr led_mask;
		public int global_auto_repeat;
		public AutoRepeats auto_repeats;

		[StructLayout(LayoutKind.Explicit)]
		public struct AutoRepeats
		{
			[FieldOffset(0)]
			public byte first;

			[FieldOffset(31)]
			public byte last;
		}
	}

	public enum GCJoinStyle
	{
		JoinMiter = 0,
		JoinRound = 1,
		JoinBevel = 2
	}

	public enum GCLineStyle
	{
		LineSolid = 0,
		LineOnOffDash = 1,
		LineDoubleDash = 2
	}

	public enum GCCapStyle
	{
		CapNotLast = 0,
		CapButt = 1,
		CapRound = 2,
		CapProjecting = 3
	}

	public enum GCFillStyle
	{
		FillSolid = 0,
		FillTiled = 1,
		FillStippled = 2,
		FillOpaqueStppled = 3
	}

	public enum GCFillRule
	{
		EvenOddRule = 0,
		WindingRule = 1
	}

	public enum GCArcMode
	{
		ArcChord = 0,
		ArcPieSlice = 1
	}

	public enum GCSubwindowMode
	{
		ClipByChildren = 0,
		IncludeInferiors = 1
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XGCValues
	{
		public GXFunction function;
		public IntPtr plane_mask;
		public IntPtr foreground;
		public IntPtr background;
		public int line_width;
		public GCLineStyle line_style;
		public GCCapStyle cap_style;
		public GCJoinStyle join_style;
		public GCFillStyle fill_style;
		public GCFillRule fill_rule;
		public GCArcMode arc_mode;
		public IntPtr tile;
		public IntPtr stipple;
		public int ts_x_origin;
		public int ts_y_origin;
		public IntPtr font;
		public GCSubwindowMode subwindow_mode;
		public bool graphics_exposures;
		public int clip_x_origin;
		public int clib_y_origin;
		public IntPtr clip_mask;
		public int dash_offset;
		public byte dashes;
	}

	public enum GXFunction
	{
		GXclear = 0x0,        /* 0 */
		GXand = 0x1,        /* src AND dst */
		GXandReverse = 0x2,        /* src AND NOT dst */
		GXcopy = 0x3,        /* src */
		GXandInverted = 0x4,        /* NOT src AND dst */
		GXnoop = 0x5,        /* dst */
		GXxor = 0x6,        /* src XOR dst */
		GXor = 0x7,        /* src OR dst */
		GXnor = 0x8,        /* NOT src AND NOT dst */
		GXequiv = 0x9,        /* NOT src XOR dst */
		GXinvert = 0xa,        /* NOT dst */
		GXorReverse = 0xb,        /* src OR NOT dst */
		GXcopyInverted = 0xc,        /* NOT src */
		GXorInverted = 0xd,        /* NOT src OR dst */
		GXnand = 0xe,        /* NOT src OR NOT dst */
		GXset = 0xf        /* 1 */
	}

	public enum MapState
	{
		IsUnmapped = 0,
		IsUnviewable = 1,
		IsViewable = 2
	}

	[Flags]
	public enum XSizeHintsFlags
	{
		USPosition = (1 << 0),
		USSize = (1 << 1),
		PPosition = (1 << 2),
		PSize = (1 << 3),
		PMinSize = (1 << 4),
		PMaxSize = (1 << 5),
		PResizeInc = (1 << 6),
		PAspect = (1 << 7),
		PAllHints = (PPosition | PSize | PMinSize | PMaxSize | PResizeInc | PAspect),
		PBaseSize = (1 << 8),
		PWinGravity = (1 << 9),
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XSizeHints
	{
		public IntPtr flags;
		public int x;
		public int y;
		public int width;
		public int height;
		public int min_width;
		public int min_height;
		public int max_width;
		public int max_height;
		public int width_inc;
		public int height_inc;
		public int min_aspect_x;
		public int min_aspect_y;
		public int max_aspect_x;
		public int max_aspect_y;
		public int base_width;
		public int base_height;
		public int win_gravity;
	}

	[Flags]
	public enum XWMHintsFlags
	{
		InputHint = (1 << 0),
		StateHint = (1 << 1),
		IconPixmapHint = (1 << 2),
		IconWindowHint = (1 << 3),
		IconPositionHint = (1 << 4),
		IconMaskHint = (1 << 5),
		WindowGroupHint = (1 << 6),
		AllHints = (InputHint | StateHint | IconPixmapHint | IconWindowHint | IconPositionHint | IconMaskHint | WindowGroupHint)
	}

	public enum XInitialState
	{
		DontCareState = 0,
		NormalState = 1,
		ZoomState = 2,
		IconicState = 3,
		InactiveState = 4
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XWMHints
	{
		public IntPtr flags;
		public bool input;
		public XInitialState initial_state;
		public IntPtr icon_pixmap;
		public IntPtr icon_window;
		public int icon_x;
		public int icon_y;
		public IntPtr icon_mask;
		public IntPtr window_group;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct XIconSize
	{
		public int min_width;
		public int min_height;
		public int max_width;
		public int max_height;
		public int width_inc;
		public int height_inc;
	}

	public enum XRequest : byte
	{
		X_CreateWindow = 1,
		X_ChangeWindowAttributes = 2,
		X_GetWindowAttributes = 3,
		X_DestroyWindow = 4,
		X_DestroySubwindows = 5,
		X_ChangeSaveSet = 6,
		X_ReparentWindow = 7,
		X_MapWindow = 8,
		X_MapSubwindows = 9,
		X_UnmapWindow = 10,
		X_UnmapSubwindows = 11,
		X_ConfigureWindow = 12,
		X_CirculateWindow = 13,
		X_GetGeometry = 14,
		X_QueryTree = 15,
		X_InternAtom = 16,
		X_GetAtomName = 17,
		X_ChangeProperty = 18,
		X_DeleteProperty = 19,
		X_GetProperty = 20,
		X_ListProperties = 21,
		X_SetSelectionOwner = 22,
		X_GetSelectionOwner = 23,
		X_ConvertSelection = 24,
		X_SendEvent = 25,
		X_GrabPointer = 26,
		X_UngrabPointer = 27,
		X_GrabButton = 28,
		X_UngrabButton = 29,
		X_ChangeActivePointerGrab = 30,
		X_GrabKeyboard = 31,
		X_UngrabKeyboard = 32,
		X_GrabKey = 33,
		X_UngrabKey = 34,
		X_AllowEvents = 35,
		X_GrabServer = 36,
		X_UngrabServer = 37,
		X_QueryPointer = 38,
		X_GetMotionEvents = 39,
		X_TranslateCoords = 40,
		X_WarpPointer = 41,
		X_SetInputFocus = 42,
		X_GetInputFocus = 43,
		X_QueryKeymap = 44,
		X_OpenFont = 45,
		X_CloseFont = 46,
		X_QueryFont = 47,
		X_QueryTextExtents = 48,
		X_ListFonts = 49,
		X_ListFontsWithInfo = 50,
		X_SetFontPath = 51,
		X_GetFontPath = 52,
		X_CreatePixmap = 53,
		X_FreePixmap = 54,
		X_CreateGC = 55,
		X_ChangeGC = 56,
		X_CopyGC = 57,
		X_SetDashes = 58,
		X_SetClipRectangles = 59,
		X_FreeGC = 60,
		X_ClearArea = 61,
		X_CopyArea = 62,
		X_CopyPlane = 63,
		X_PolyPoint = 64,
		X_PolyLine = 65,
		X_PolySegment = 66,
		X_PolyRectangle = 67,
		X_PolyArc = 68,
		X_FillPoly = 69,
		X_PolyFillRectangle = 70,
		X_PolyFillArc = 71,
		X_PutImage = 72,
		X_GetImage = 73,
		X_PolyText8 = 74,
		X_PolyText16 = 75,
		X_ImageText8 = 76,
		X_ImageText16 = 77,
		X_CreateColormap = 78,
		X_FreeColormap = 79,
		X_CopyColormapAndFree = 80,
		X_InstallColormap = 81,
		X_UninstallColormap = 82,
		X_ListInstalledColormaps = 83,
		X_AllocColor = 84,
		X_AllocNamedColor = 85,
		X_AllocColorCells = 86,
		X_AllocColorPlanes = 87,
		X_FreeColors = 88,
		X_StoreColors = 89,
		X_StoreNamedColor = 90,
		X_QueryColors = 91,
		X_LookupColor = 92,
		X_CreateCursor = 93,
		X_CreateGlyphCursor = 94,
		X_FreeCursor = 95,
		X_RecolorCursor = 96,
		X_QueryBestSize = 97,
		X_QueryExtension = 98,
		X_ListExtensions = 99,
		X_ChangeKeyboardMapping = 100,
		X_GetKeyboardMapping = 101,
		X_ChangeKeyboardControl = 102,
		X_GetKeyboardControl = 103,
		X_Bell = 104,
		X_ChangePointerControl = 105,
		X_GetPointerControl = 106,
		X_SetScreenSaver = 107,
		X_GetScreenSaver = 108,
		X_ChangeHosts = 109,
		X_ListHosts = 110,
		X_SetAccessControl = 111,
		X_SetCloseDownMode = 112,
		X_KillClient = 113,
		X_RotateProperties = 114,
		X_ForceScreenSaver = 115,
		X_SetPointerMapping = 116,
		X_GetPointerMapping = 117,
		X_SetModifierMapping = 118,
		X_GetModifierMapping = 119,
		X_NoOperation = 127
	}

	[Flags]
	public enum WindowType
	{
		Client = 1,
		Whole = 2,
		Both = 3
	}

	public enum ImageFormat
	{
		XYPixmap = 1,
		ZPixmap
	}
}
