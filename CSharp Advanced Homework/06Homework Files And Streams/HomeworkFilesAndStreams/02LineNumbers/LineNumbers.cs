using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class LineNumbers
{
    static void Main(string[] args)
    {
        string source = "../../text.txt";
        string result = "../../result.txt";
        using (var reader = new StreamReader(source))
        {
            using (var writer = new StreamWriter(result))
            {
                int row = 1;
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    line = String.Format("{0}.{1}", row++, line);
                    writer.WriteLine(line);
                }
            }
        }
    }
}

