using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class CopyBinaryFile
{
    static void Main(string[] args)
    {
        string sourcePath = "../../programmers.jpg";
        string resultPath = "../../result.jpg";
        using(var source = new FileStream(sourcePath,FileMode.Open))
        {
            using (var result = new FileStream(resultPath,FileMode.Create))
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

