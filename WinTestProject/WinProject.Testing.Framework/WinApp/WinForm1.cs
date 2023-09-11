using Interop.UIAutomationClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Automation;
using WinProject.Testing.Framework.WinApp.UIElements;

namespace WinProject.Testing.Framework.WinApp
{
	public class WinForm1
	{
		private readonly AutomationElement _form;
		public WinForm1(AutomationElement form)
		{
			_form = form;
			try
			{
				_form.SetFocus();
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception occurs during setting focus to window: {0}", e.Message);
			}
		}

		public Button UploadButton => new Button(GetElement("uploadButton"));
		public Button SaveButton => new Button(GetElement("saveButton"));
		public TextBox UploadTextBox => new TextBox(GetElement("uploadTextBox"));
		public TextBox SaveTextBox => new TextBox(GetElement("saveTextBox"));
		public TextBox StatusTextBox => new TextBox(GetElement("statusTextBox"));
		public CheckBox OverwriteCheckBox => new CheckBox(GetElement("overwriteCheckBox"));


		public AutomationElement GetElement(string elementName)
		{
			var condition = new PropertyCondition(AutomationElement.IsEnabledProperty, true);
			var abc = _form.FindAll(TreeScope.TreeScope_Element | TreeScope.TreeScope_Descendants, condition);
			foreach (AutomationElement c in abc)
			{
				Console.WriteLine(c.Current.Name);
			}
			AutomationElement uiElement = null;
			uiElement = _form.FindFirst(TreeScope.TreeScope_Descendants, new PropertyCondition(AutomationElement.NameProperty, elementName));
			return uiElement;
		}
	}
}
