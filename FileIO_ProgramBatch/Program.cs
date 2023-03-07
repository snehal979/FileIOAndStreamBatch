namespace FileIO_ProgramBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            string filepath = @"C:\Users\hp\Desktop\newBatch2\FileIO_ProgramBatch\FileIO_ProgramBatch\TxtFile.txt";
            Console.WriteLine("1.exitfile 2.readallline 3.ReadAll Txt");
            int num = Convert.ToInt16(Console.ReadLine());
            switch (num)
            {
                case 1:
                    FileData.FileExist(filepath);
                    break;
                case 2:
                    FileData.ReadAllLine(filepath);
                    break;
                case 3:
                    FileData.ReadAllTxt(filepath);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
