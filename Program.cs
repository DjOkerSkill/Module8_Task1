using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("C:/FinalTask1");

                directoryInfo.Create();

                if (directoryInfo.Exists)
                {
                    directoryInfo.CreateSubdirectory("SubFolder");
                    directoryInfo.CreateSubdirectory("SubFolder2");
                }
                else
                    Console.WriteLine("папка по заданному адресу не существует");


                FileInfo fileInfo = new FileInfo("C:/FinalTask1/SubFolder/newFile.txt");

                fileInfo.Create();

                if (fileInfo.Exists)
                {
                    Console.WriteLine($"Создан файл с именем {fileInfo.FullName}");
                }
                else
                    Console.WriteLine($"файл {fileInfo.FullName} не существует") ;

                
                fileInfo = new FileInfo("C:/FinalTask1/SubFolder/newFile2.txt");

                    fileInfo.Create();

                if (fileInfo.Exists)
                {
                    Console.WriteLine($"Создан файл с именем {fileInfo.FullName}");
                }
                else
                    Console.WriteLine($"файл {fileInfo.FullName} не существует");

                Extenshion.DirSize(directoryInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}




