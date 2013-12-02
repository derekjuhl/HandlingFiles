using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //get the input/output libraries

namespace HandlingFiles
{
    class ReadFiles
    {
        /// <summary>
        /// This class reads existing files
        /// using a streamReader object
        /// The constructor takes the path
        /// for the file
        /// it contains a public method
        /// that returns the file contents
        /// as a string
        /// </summary>
        private StreamReader reader;
        private string filePath;
        public ReadFiles(string path)
        {
            filePath = path;
  
        }

        public string GetFile()
        {
            reader = new StreamReader(filePath);
            string line = null;
            //a try catch is necessary here
            //to handle instances in which the file 
            //cannot be found or is unreadable
            try
            {
                //we try to open the file
                line = reader.ReadToEnd();
            }
            catch 
            {
                //if we fail we throw the error back
                //to the calling class
                throw new Exception("The file could not be read");
            }
            return line;
        }
    }
}
