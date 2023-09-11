using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Automation;

namespace WinProject.Testing.Framework.WinApp.UIElements
{
	public class TextBox
	{
		AutomationElement _element;
		public TextBox(AutomationElement element)
		{
			_element = element;
		}

		public string Value
		{
			get
			{
				object valuePattern;
				_element.TryGetCurrentPattern(ValuePattern.Pattern, out valuePattern);
				return ((ValuePattern)valuePattern).Current.Value;
			}
			set
			{
				_element.SetFocus();
				object valuePattern;
				_element.TryGetCurrentPattern(ValuePattern.Pattern, out valuePattern);
				((ValuePattern)valuePattern).SetValue(value);
			}
		}

	}
}
