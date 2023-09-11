using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace WinProject.Testing.Framework.Input
{
	public class Mouse
	{
		private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
		private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
		private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
		private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
		private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
		private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
		private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
		private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
		private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
		private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
		private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
		private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */

		const Int32 CURSOR_SHOWING = 0x00000001;
		[DllImport("user32")]
		public static extern int SetCursorPos(int x, int y);

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		public static void MouseLeftClick(Point p)
		{
			SetCursorPos((int)p.X, (int)p.Y);
			mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)p.X, (int)p.Y, 0, 0);
			Thread.Sleep(30);
		}
	}
}
