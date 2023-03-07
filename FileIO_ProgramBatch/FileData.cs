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
    }
}
