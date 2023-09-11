using System;
using System.Windows.Automation;

namespace WinProject.Testing.Framework.WinApp.UIElements
{
	public class Button
	{
		AutomationElement _element;
		public Button(AutomationElement element)
		{
			_element = element;
		}

		public void Click()
		{
			if (_element.Current.IsEnabled)
			{
				WinElementActions.Click(_element);
			}
			else
			{
				Console.WriteLine("Disabled TextBox was clicked.");
			}
		}
	}
}
