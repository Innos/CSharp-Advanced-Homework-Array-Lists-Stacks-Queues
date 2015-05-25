using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

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
        Split(sourcePath, resultPath, parts);
        Assemble(files, sourcePath, resultPath);
    }

    static void Split(string sourcePath, string resultPath, int parts)
    {
        using (var source = new FileStream(sourcePath, FileMode.Open))
        {
            long a = source.Length;
            int sizeOfChunk = (int)Math.Ceiling((double)source.Length / parts);
            for (int i = 1; i <= parts; i++)
            {
                using (var result = new FileStream(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + ".gz", FileMode.Create))
                {
                    using (var compress = new GZipStream(result, CompressionMode.Compress))
                    {
                        files.Add(resultPath + Path.GetFileNameWithoutExtension(sourcePath) + "-" + i + ".gz");
                        byte[] buffer = new byte[sizeOfChunk];
                        int readBytes = source.Read(buffer, 0, sizeOfChunk);
                        if (readBytes > 0)
                        {
                            compress.Write(buffer, 0, readBytes);
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
                    using (var decompress = new GZipStream(source, CompressionMode.Decompress))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = decompress.Read(buffer, 0, buffer.Length);
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
}

