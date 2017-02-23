using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool result;

            do
            {
                Console.Write("Give a name (enter ends) :");
                string line = Console.ReadLine();
                char name;
                result = char.TryParse(line, out name);

                if (result)
                {
                    list.Add(name);
                }
            }
            while (result);

            list.ForEach(item => Console.WriteLine(item));
            Console.ReadLine();

            {
                System.IO.StreamWriter outputFile = null;
                try
                {
                    outputFile = new System.IO.StreamWriter(@"c:\Users\suvij");
                    outputFile.WriteLine("Here is a sample text to file.");
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Some exception happened!");
                    Console.WriteLine(ex.Message); // Access to the path 'c:\test.file' is denied.
                }
                finally
                {
                    // check for null because OpenWrite might have failed
                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }

        }
    }
}
