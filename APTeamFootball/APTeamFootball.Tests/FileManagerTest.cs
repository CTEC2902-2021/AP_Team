using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using APTeamFootball.Models;

namespace APTeamFootball.Tests
{
    /// <summary>
    /// Summary description for FileManagerTest
    /// </summary>
    [TestClass]
    public class FileManagerTest
    {
        //private const string TEST_FILE_PATH = @"C:\Users\Sulur\Documents\Desktop\New folder\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\TestContent.txt";
        private const string TEST_FILE_PATH = @"C:\Users\2115\source\repos\CTEC2902-Labs-1\Week17-ErrorHandlingWebsite\ErrorProneWebsite.Tests\TestContent\TestContent.txt";
        [TestMethod]
        public void TheFileManagerCanReadAFile()
        {
            FileManager fileManager = new FileManager(TEST_FILE_PATH);

            Assert.AreEqual("Here is some test content.", fileManager.GetContent());


        }

        [TestMethod]
        public void TheFileManagerHandlesAMissingFile()
        {
            FileManager fileManager =
            new FileManager(@"C:\MissingFileThereIsNoFileHere.txt");
            Assert.IsTrue(fileManager.GetContent().Contains("Oops! The content could not be found at the location specified."));
        }


        //how to test any class in my project
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TheSystemThrowsAFileNotFoundExceptionWhenGivenAPathToAMissingFile()
        {
            FileManager fileManager = new
            FileManager(@"C:\MissingFileThereIsNoFileHere.txt");
            Assert.IsTrue(fileManager.GetEvenMoreContent().Contains("This line won't execute as the exception will be thrown before it's hit"));
        }





    }

}
