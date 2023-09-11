using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Automation;
using WinProject.Testing.Framework.Input;

namespace WinProject.Testing.Framework.WinApp
{
	public class WinElementActions
	{
		public static void Click(AutomationElement element)
		{
			var point = CountPointsByRect(element);
			Click(point);
		}

		public static Point CountPointsByRect(AutomationElement element)
		{
			if (element != null)
			{
				var rect = element.Current.BoundingRectangle;
				return new Point((int)((rect.Right + rect.Left) / 2), (int)((rect.Bottom + rect.Top) / 2));
			}
			throw new Exception("Can't get rectangle for null element");
		}

		public static void Click(Point point)
		{
			Mouse.MouseLeftClick(point);
		}
	}
}
