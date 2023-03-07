namespace FileIO_ProgramBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            string binnaryFilePath = @"C:\Users\hp\Desktop\newBatch2\FileIO_ProgramBatch\FileIO_ProgramBatch\BinnaryTxtFile.txt";
            string filepath = @"C:\Users\hp\Desktop\newBatch2\FileIO_ProgramBatch\FileIO_ProgramBatch\TxtFile.txt";
            FileData fileData = new FileData();
            BinarySerilization binarySerilization = new BinarySerilization();
            JsonSerializationDeserialization json = new JsonSerializationDeserialization();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.exitfile 2.readallline 3.ReadAll Txt 4.Copy file 5.Delect file 6.Read file streamReader 7.Write File" +
                    " \n 8.Serialization and 9 .Deserization \n 10 Json data Serialization 11. json data deserialization"); 
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
                    case 4:
                        FileData.Copy(filepath);
                        break;
                    case 5:
                        FileData.Delect();
                        break;
                    case 6:
                        fileData.ReadFromStreamReader(filepath);
                        break;
                    case 7:
                        fileData.WriteUsingStreamWriter(filepath);
                        break;
                    case 8:
                        binarySerilization.Serialization(binnaryFilePath);
                        break; 
                    case 9:
                        binarySerilization.DeSerialization(binnaryFilePath);
                        break;
                    case 10:
                        json.JsonSerialize();
                        break;
                    case 11:
                        json.JsonDeserialization();
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        flag =false;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
