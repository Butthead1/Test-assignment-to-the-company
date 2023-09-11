using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinProject.Library
{
	public class Save
	{
		public static void SaveFile(string pathToResultFile, byte[] content)
		{
			File.WriteAllBytes(pathToResultFile, content);
		}
	}
}
