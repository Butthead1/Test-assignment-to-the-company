using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinProject.Library
{
	public class Upload
	{
		public static byte[] UploadFile(string pathToFile)
		{
			byte[] readFile = File.ReadAllBytes(pathToFile);
			return readFile;
		}
	}
}
