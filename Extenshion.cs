using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp6
{
    internal class Extenshion
    {
        public static void DirSize(DirectoryInfo di)
        {
            TimeSpan timeSpan = TimeSpan.FromMinutes(30);

            FileInfo[] fl = di.GetFiles();

            foreach (FileInfo fi in fl)
            {
                TimeSpan deltatime = DateTime.Now - File.GetLastWriteTime(fi.FullName);
                
                if (deltatime > timeSpan)
                    fi.Delete();
            }

            DirectoryInfo[] dr = di.GetDirectories();

            foreach (DirectoryInfo df in dr)
            {
                TimeSpan deltatime = DateTime.Now - Directory.GetLastWriteTime(df.FullName);

                if (deltatime > timeSpan)
                    df.Delete(true);

                DirSize(df);
            }
            
        }
    }
}
