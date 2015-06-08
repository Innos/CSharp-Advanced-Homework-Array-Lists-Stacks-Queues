using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                uint num = uint.Parse(Console.ReadLine());
                var sqrt = Math.Sqrt(num);
                Console.WriteLine(sqrt);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
