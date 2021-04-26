using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using log4net;

namespace APTeamFootball.Models
{
    public class FileManager
    {

        private string _contentFilePath;
        //declaring logger, object declaration with class scope
        private readonly ILog logger = LogManager.GetLogger(typeof(FileManager).Name);

        public FileManager(string contentFilePath)
        {
            // TODO: Complete member initialization
            this._contentFilePath = contentFilePath;
        }


        //for task we need to use whether try and catch or the other method to test
        //we need to know how to log error
        public string GetContent()
        {
            string contentMessage = String.Empty;
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(_contentFilePath);
                contentMessage = streamReader.ReadToEnd();
            }

            catch (FileNotFoundException fnfEx)
            {
                contentMessage = String.Format("{0}{1}{2}",
                "Oops! The content could not be found at the location specified.",
                Environment.NewLine,
                fnfEx.Message);
                //log the error into the text file
                logger.Error("The content file was not found");
            }

            catch (Exception ex)
            {
                contentMessage = String.Format("{0}{1}{2}",
                "Blimey! Something totally unexpected just happened!",
                Environment.NewLine,
                ex.Message);
                logger.Error("The content file was not found");
            }
            finally

            {
                if (streamReader != null) streamReader.Close();
            }



            return contentMessage;
        }




        public string GetEvenMoreContent()
        {
            string contentMessage = String.Empty;
            if (!File.Exists(_contentFilePath)) throw new FileNotFoundException(
            "The content file doesn't exist in the location specified...");
            using (StreamReader streamReader = new StreamReader(_contentFilePath))
            {
                contentMessage = streamReader.ReadToEnd();
            }
            return contentMessage;


        }

    }
}