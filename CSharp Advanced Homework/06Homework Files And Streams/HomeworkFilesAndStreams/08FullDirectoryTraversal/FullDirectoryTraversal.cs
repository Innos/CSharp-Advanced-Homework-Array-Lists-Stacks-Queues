using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class FullDirectoryTraversal
{
    static string destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

    static void Main(string[] args)
    {
        string directory = Console.ReadLine();
        //Creating a new report.txt because the writer in the method appends (would just continue writing to the old file if we started the program again)
        using (FileStream fs = File.Create(destination)) { }
        DirectoryInfo di = new DirectoryInfo(directory);
        WalkDirectories(di);
    }

    static void WalkDirectories(DirectoryInfo root)
    {
        //getting the files and dirs
        FileInfo[] files = root.GetFiles();
        DirectoryInfo[] subdirs = root.GetDirectories();

        //sorting files
        var sortedfiles = files
           .OrderBy(file => file.Length)
           .GroupBy(file => file.Extension)
           .OrderByDescending(group => group.Count())
           .ThenBy(group => group.Key);

        //initializing a writer, note that the FileMode is Append
        using (var fileStream = new FileStream(destination,FileMode.Append))
        {
            using (var writer = new StreamWriter(fileStream))
            {        
                //typing root folder and printing a line to denote contents (increases readability)
                writer.WriteLine(root);
                writer.WriteLine(new string('-',25));

                //typing dirs
                foreach (var dir in subdirs)
                {
                    writer.WriteLine("{0} <directory>", dir.Name);
                }

                //if both dirs and files exist in the root folder seperate them by a space
                if (subdirs.Length > 0 && sortedfiles.Count() > 0) writer.WriteLine();
                //if there are no files or folders in root print <empty>
                else if (subdirs.Length == 0 && sortedfiles.Count() == 0) writer.WriteLine("<empty>");

                //printing the files grouped by extension
                foreach (var group in sortedfiles)
                {
                    writer.WriteLine("  {0}", group.Key);
                    foreach (var file in group)
                    {
                        writer.WriteLine("      --{0} - {1:F3}kb", file, (file.Length / 1024m));
                    }
                }
                writer.WriteLine();
            }  
        }
        //recursively calling the method for the sub directories
        foreach (var subdir in subdirs)
        {
            WalkDirectories(subdir);
        }
    }
}

