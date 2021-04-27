using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using APTeamFootball.Models;

namespace APTeamFootball.Tests
{

    [TestClass]
    public class FileManagerTest
    {
        
        private const string TEST_FILE_PATH = @"NEEDS TO BE CHANGED ACCORDING USER'S PATH";
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
