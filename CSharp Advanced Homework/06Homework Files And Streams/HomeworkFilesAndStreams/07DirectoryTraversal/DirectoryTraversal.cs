using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class DirectoryTraversal
{
    static void Main(string[] args)
    {
        string destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
        string directory = Console.ReadLine();

        DirectoryInfo di = new DirectoryInfo(directory);
        FileInfo[] files = di.GetFiles();

        var sortedfiles = files
            .OrderBy(file => file.Length)
            .GroupBy(file => file.Extension)
            .OrderByDescending(group => group.Count())
            .ThenBy(group => group.Key);

        using (var writer = new StreamWriter(destination))
        {
            foreach (var group in sortedfiles)
            {
                writer.WriteLine(group.Key);
                foreach (var file in group)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", file, (file.Length / 1024m));
                }
            }
        }
    }
}

