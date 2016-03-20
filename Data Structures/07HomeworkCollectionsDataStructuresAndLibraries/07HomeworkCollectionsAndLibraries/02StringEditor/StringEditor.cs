using System;

namespace _02StringEditor
{
    using Wintellect.PowerCollections;

    public class StringEditor
    {
        private BigList<char> editor;

        public StringEditor()
        {
            editor = new BigList<char>();
        }

        public void Append(string text)
        {
            editor.AddRange(text);
            Console.WriteLine("OK");
        }

        public void Insert(int index, string text)
        {
            if (index < 0 || index >= editor.Count)
            {
                Console.WriteLine("ERROR");
                return;
            }
            editor.InsertRange(index,text);
            Console.WriteLine("OK");
        }

        public void Delete(int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= editor.Count || startIndex + count >= editor.Count)
            {
                Console.WriteLine("ERROR");
                return;
            }
            editor.RemoveRange(startIndex,count);
            Console.WriteLine("OK");
        }

        public void Replace(int startIndex, int count, string substring)
        {
            if (startIndex<0 || startIndex >= editor.Count || startIndex+count >= editor.Count)
            {
                Console.WriteLine("ERROR");
                return;
            }
            editor.RemoveRange(startIndex,count);
            editor.InsertRange(startIndex,substring);
            Console.WriteLine("OK");
        }

        public void Print()
        {
            Console.WriteLine(string.Join("",editor));
        }
    }
}
