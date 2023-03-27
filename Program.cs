using System;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection;
using System.Runtime;


class Program
{
    public static void Main()
    {

        string dirName = Console.ReadLine();

        var directory = new DirectoryInfo(dirName);

        if (directory.Exists)
        {
            Console.WriteLine("Directories:");
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo dir in dirs)

            {
                try
                {
                    Console.WriteLine(dir.Name);
                    var first = dir.LastAccessTime;
                    var secondt = DateTime.Now;
                    var delyt = secondt - first;
                    var dely = TimeSpan.FromMinutes(30);

                    if (delyt >= dely && dir.Exists)
                    {
                        dir.Delete(true);
                        Console.WriteLine("Directory deleted");

                    }

                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            Console.WriteLine("Files:");
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                try
                {
                    Console.WriteLine(file.Name);
                    var first = file.CreationTime;
                    var secondt = DateTime.Now;
                    var delyt = secondt - first;
                    var dely = TimeSpan.FromMinutes(30);
                    if (delyt >= dely && file.Exists)
                    {
                        file.Delete();
                        Console.WriteLine("File deleted");

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }


            }

        }
        else { Console.WriteLine("Directory doesn't exist"); }






    }
}

