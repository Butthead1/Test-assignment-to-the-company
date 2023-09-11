using Interop.UIAutomationClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Automation;

namespace WinProject.Testing.Framework.WinApp
{
	public class Starter
	{
		private static Process _process;
		public static void KillApplication()
		{
			_process.Kill();
		}
		public static AutomationElement StartApplication(string applicationPath)
		{

			AutomationElement formElement = null;
			_process = new Process();

			var processStartInfo = new ProcessStartInfo { FileName = applicationPath };
			_process.StartInfo = processStartInfo;
			Console.WriteLine("Trying to start '" + applicationPath + "'");
			_process.Start();

			for (int t = 1; t < 20; t++)
			{
				AutomationElement rootElement = AutomationElement.RootElement;
				var winCollection = rootElement.FindAll(TreeScope.TreeScope_Children, new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window));

				foreach (AutomationElement element in winCollection)
					if (element.Current.Name.Contains("Form1"))
						formElement = element;
			}
			return formElement;
		}
	}
}
