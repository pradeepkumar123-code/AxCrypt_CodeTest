using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxCrypt_v2
{
    public class FileRead
    {
        /// <summary>
        /// Read the all lines from the file (one number per line) and parses it and return sum 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public int AddNumbersInFile(string filePath)
        {
            try
            {
                int sum = 0;

                string fullPath = Path.Combine(Directory.GetCurrentDirectory().Split("bin")[0], filePath);

                if (!File.Exists(fullPath)) {
                    Console.WriteLine("The specified file does not exist in this path "+ fullPath + ".");
                }

                string[] lines = File.ReadAllLines(fullPath);

                foreach (string line in lines)
                {
                    var val = new string(line.Where(Char.IsDigit).ToArray());

                    if (int.TryParse(val, out int number))
                    {
                        sum += number;
                    }
                }

                return sum;
            }
            catch (Exception ex) {
                Console.WriteLine("An unexpected error occurs" , ex.Message);
                throw;
            }
        }
    }
}
