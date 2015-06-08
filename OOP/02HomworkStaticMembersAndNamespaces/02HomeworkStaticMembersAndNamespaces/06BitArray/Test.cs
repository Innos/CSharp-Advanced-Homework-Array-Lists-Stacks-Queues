using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace BitArray
{
    class Test
    {
        static void Main(string[] args)
        {
            //BitArray using BigInt
            Console.WriteLine("Bit Array (Big Integer):");
            BitArrayBigInt a = new BitArrayBigInt(50);
            Console.WriteLine("Initial value = {0}", a);
            a[49] = 1;
            a[23] = 1;
            Console.WriteLine("Value after setting #49 to 1 and #23 to 1 = {0}", a);
            Console.WriteLine("Value of position #49 = {0}", a[49]);
            a[49] = 0;
            Console.WriteLine("Value after setting #49 to 0 = {0}", a);
            Console.WriteLine("Value of position #49 = {0}", a[49]);

            //BitAray using an array
            Console.WriteLine();
            Console.WriteLine("Bit Array:");
            BitArray b = new BitArray(50);
            Console.WriteLine("Initial value = {0}", b);
            b[49] = 1;
            b[23] = 1;
            Console.WriteLine("Value after setting #49 to 1 and #23 to 1 = {0}", b);
            Console.WriteLine("Value of position #49 = {0}", b[49]);
            b[49] = 0;
            Console.WriteLine("Value after setting #49 to 0 = {0}", b);
            Console.WriteLine("Value of position #49 = {0}", b[49]);

            //Speed Tests

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Print Test:\n");
            //Stopwatch watch = new Stopwatch();

            ////BitArray using BigInt
            //watch.Start();
            //Console.WriteLine("Bit Array (Big Integer):");
            //BitArrayBigInt c = new BitArrayBigInt(10000);
            //c[4900] = 1;
            //c[2300] = 1;
            //Console.WriteLine("Value = {0}",c);
            //Console.WriteLine();
            //c[4900] = 0;
            //Console.WriteLine("Value = {0}",c);
            //watch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(watch.Elapsed);

            ////BitAray using an array
            //watch.Restart();
            //Console.WriteLine();
            //Console.WriteLine("Bit Array:");
            //BitArray d = new BitArray(10000);
            //d[4900] = 1;
            //d[2300] = 1;
            //Console.WriteLine("Value = {0}", d);
            //Console.WriteLine();
            //d[4900] = 0;
            //Console.WriteLine("Value = {0}",d);
            //watch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(watch.Elapsed);
            ////Calculating the number is way too slow, need a better algorithm

            ////BitArray using BigInt
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Insertion test:\n");
            //watch.Restart();
            //Console.WriteLine("Bit Array (Big Integer):");
            //for (int i = 0; i < 2000; i++)
            //{
            //    c[i] = 1;
            //}
            //watch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(watch.Elapsed);

            ////BitAray using an array
            //watch.Restart();
            //Console.WriteLine();
            //Console.WriteLine("Bit Array:");
            //for (int i = 0; i < 2000; i++)
            //{
            //    d[i] = 1;
            //}
            //watch.Stop();
            //Console.WriteLine();
            //Console.WriteLine(watch.Elapsed);
            
        }
    }
}
