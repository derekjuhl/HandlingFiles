using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //add the Input/Output miles

namespace HandlingFiles
{
    class WriteFiles
    {
        /// <summary>
        /// this class takes in a path name 
        /// and initiates a streamWriter object
        /// the AddToFile method
        /// writes the text to the file
        /// the close file closes the file,
        /// but in case it doesn't get called
        /// the class also contains a destructor
        /// which makes sure the file gets closed
        /// </summary>
        StreamWriter file;
        public WriteFiles(string path)
        {
         
            //initiate the stream reader
            //the true means to append new text
            //rather than overwrite the file
            file = new StreamWriter(path, true);
        }

        public void AddToFile(string line)
        {
            //write the string sent in
            file.WriteLine(line);
            
        }

        public void CloseFile()
        {
            //close the file
            //a file cannot be accessed if it is open
            file.Close();
        }

        ~WriteFiles()
        {
            //this is the destructor
            //it is here to make sure the file is actually
            //closed
            if (file != null)
                file.Close();
        }

    }
}
