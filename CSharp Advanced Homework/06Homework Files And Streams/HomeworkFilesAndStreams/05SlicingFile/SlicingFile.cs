using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class SlicingFile
{
    static List<string> files = new List<string>();

    static void Main(string[] args)
    {
        //THE PROGRAM REQUIRES INPUT - the number of parts to get after slicing 
        //File to Slice you can change it if you want, currently points to "programmers.jpg" in the main folder of the project -> ../05SlicingFile/
        string sourcePath = "../../programmers.jpg";

        //Result folder
        string resultPath = "../../result/";

        //Creates a directory called "result" in the main folder of the project (where the .cs file is) and stores the results there
        //You can delete the "result" folder before you run the program to see it works
        Directory.CreateDirectory(Path.GetDirectoryName(resultPath));

        //input
        int parts = int.Parse(Console.ReadLine());

        //methods
        Slice(sourcePath, resultPath, parts);
        Assemble(files, sourcePath, resultPath);
    }

    static void Slice(string sourcePath, string resultPath, int parts)
    {
        using (var source = new FileStream(sourcePath, FileMode.Open))
        {
            long a = source.Length;
            int sizeOfChunk = (int)Math.Ceiling((double)source.Length / parts);
            for (int i = 1; i <= parts; i++)
            {
                using (var result = new FileStream(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + Path.GetExtension(sourcePath), FileMode.Create))
                {
                    files.Add(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + Path.GetExtension(sourcePath));
                    while (result.Position < sizeOfChunk)
                    {
                        //since windows writes on chunks of 4096 bytes it's impossible to realisticaly save space by spliting lower,
                        //(a 2kb file still takes 4096 bytes on disk), but in order to avoid 0 kb parts as much as possible,
                        //if the size of a part is less than 4096, set the buffer size to that of a part
                        byte[] buffer;
                        if (sizeOfChunk > 4096) buffer = new byte[4096];
                        else buffer = new byte[sizeOfChunk];

                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        result.Write(buffer, 0, readBytes);

                        if (readBytes <= 0 || result.Position >= sizeOfChunk)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }

    static void Assemble(List<string> files, string sourcePath, string resultPath)
    {
        using (var result = new FileStream(resultPath + Path.GetFileName(sourcePath), FileMode.Create))
        {
            for (int i = 0; i < files.Count; i++)
            {
                using (var source = new FileStream(files[i], FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        result.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}

