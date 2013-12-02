using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingFiles
{
    class Program
    {
        string path = null;
        static void Main(string[] args)
        {
            Program p = new Program();
            //call writelines method
            p.WriteLines();
            //this is just to seperate the write 
            //file from the read
            Console.WriteLine("********************************");
            p.ReadFile();
           

            Console.ReadKey();
        }

        private void WriteLines()
        {
            //for this method we get the file path
            Console.WriteLine("Enter the path and name of the file");
            path = Console.ReadLine();

            //we initiate the WriteFiles class
            //passing the path to its constructor
            WriteFiles wf = new WriteFiles(path);

            //we add whatever text you want to add to the file
            Console.WriteLine("Enter the text you want in the file");
            string text = Console.ReadLine();

            //class the AddToFile method
            wf.AddToFile(text);

            //call the close file method
            wf.CloseFile();
        }

        private void ReadFile()
        {
           

            try
            {
                //try to read the file
                ReadFiles file = new ReadFiles(path);
                //get the file contents
                Console.WriteLine(file.GetFile());
            }
            catch (Exception ex)
            {
                //if the read fails display the
                //error message
                Console.WriteLine(ex.Message);
            }

        }
    }
}
