using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class OddLines
{
    static void Main(string[] args)
    {
        int row = 0;
        string path = "../../text.txt";
        using(var reader = new StreamReader(path))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                if(row % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                row++;
            }
        }
    }
}

