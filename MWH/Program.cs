using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MWH
{
    class Program
    {

        static void Main(string[] args)
        {
      
            Regex rgx = new Regex(@"[^\u0000-\u007F]", RegexOptions.Compiled);
            string filepath = @"C:\Users\james\source\repos\MWH\MWH\chars.ach.txt";


            using (StreamReader streamReader = File.OpenText(filepath))
            {

                string s = "";
                Console.WriteLine(" Here is the content of the file : ");
                while ((s = streamReader.ReadLine()) != null)
                {

                    foreach (Match match in rgx.Matches(s))
                        Console.WriteLine("Found '{0}' at position {1}",
                                          match.Value, match.Index);

                }
            }

        }
    }
}
    
