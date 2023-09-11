using NUnit.Framework;
using System.IO;
using System.Windows.Automation;
using WinProject.Testing.Framework.WinApp;

namespace WinProject.Testing.Tests
{
	[TestFixture]
	[NonParallelizable]
	public class Test
	{
		internal WinForm1 winForm1;
		private AutomationElement window;
        [SetUp]
		public void SetUp()
		{
			window = Starter.StartApplication(@"D:\New folder\WinTestProject\WinProject.WinForms\bin\Debug\netcoreapp3.1\WinProject.WinForms.exe");
			winForm1 = new WinForm1(window);			
		}

		[TearDown]
		public void TearDown()
		{
			Starter.KillApplication();
		}
        // Before performing the test, you need to change the path to the folder
        [Test]
		public void FirstTest()
        {
			//Arrange
            string path = @"D:\New folder\Output.txt"; 
            var recentChangesBeforeTest = File.GetLastWriteTime(path);
            var fileContentsBefore = File.ReadAllLines(path);

            //Act
            winForm1.UploadTextBox.Value = @"D:\New folder\Input.txt";
            winForm1.SaveTextBox.Value = path; 
            winForm1.OverwriteCheckBox.Click();
            winForm1.UploadButton.Click();
            winForm1.SaveButton.Click();

            var fileContentsAfter = File.ReadAllLines(path);

			//Assert
			Assert.AreEqual(recentChangesBeforeTest, File.GetLastWriteTime(path));
			Assert.AreEqual(fileContentsBefore[0], fileContentsAfter[0]);
            Assert.AreEqual(winForm1.StatusTextBox.Value, "Status: File cannot be overwritten");
        }
        [Test]
        public void SecondTest()
		{
            //Arrange
            string path = @"D:\New folder\Task2.txt";

            //Act
            winForm1.UploadTextBox.Value = path;
            winForm1.UploadButton.Click();   
			var fileContents = File.ReadAllLines(path);

            //Assert
            Assert.AreEqual(winForm1.StatusTextBox.Value, "Status: File is uploaded");
            Assert.AreEqual(fileContents[0], "Content_Content_Content");
        }
    }
}
