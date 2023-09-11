using Interop.UIAutomationClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Automation;
using WinProject.Testing.Framework.Input;

namespace WinProject.Testing.Framework.WinApp.UIElements
{
	public class CheckBox
	{
		AutomationElement _element;
		private readonly TogglePattern _togglePattern;
		public CheckBox(AutomationElement element)
		{
			_element = element;
			_togglePattern = _element.GetCurrentPattern(TogglePattern.Pattern) as TogglePattern;
		}

		public ToggleState ToggleState
		{
			get
			{
				return _togglePattern.Current.ToggleState;
			}
			set
			{
				if (value != ToggleState)
				{
					Click();
				}
			}
		}

		public void Click()
		{
			if (_element.Current.IsEnabled)
			{
				WinElementActions.Click(_element);
			}
			else
			{
				Console.WriteLine("Disabled CheckBox was clicked.");
			}
		}
	}
}
