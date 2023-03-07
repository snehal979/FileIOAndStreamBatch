using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_ProgramBatch
{
    public class FileData
    {
        /// <summary>
        /// ExitFile
        /// </summary>
        public static void FileExist(string filepath)
        {
            if (File.Exists(filepath))
            {
                Console.WriteLine("File Exists");
            }
        }
        /// <summary>
        /// ReadAllLine
        /// </summary>
        /// <param name="filepath"></param>
        public static void ReadAllLine(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
    }
}
