namespace Methods
{
    using System;
    using System.Runtime.CompilerServices;

    public class Methods
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        public static string ConvertDigitToWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Digit must be a valid integer in the range [0...9]");
            }
        }

        public static int FindMaxInteger(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Collection must containt atleast one element");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintAsNumber(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static void PrintAsNumber(decimal number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static double CalculateDistance(
            double x1,
            double y1,
            double x2,
            double y2)
        {
            double distanceX = (x2 - x1) * (x2 - x1);
            double distanceY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(distanceX + distanceY);
            return distance;
        }

        public static bool IsHorizontal(double x1, double x2)
        {
            bool isOnTheSameLine = x1 == x2;
            return isOnTheSameLine;
        }

        public static bool IsVertical(double y1, double y2)
        {
            bool isOnTheSameLine = y1 == y2;
            return isOnTheSameLine;
        }

        public static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(ConvertDigitToWord(5));

            Console.WriteLine(FindMaxInteger(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(3, 3));
            Console.WriteLine("Vertical? " + IsVertical(-1, 2.5));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 03, 17), "From Sofia, born at 17.03.1992");

            Student stella = new Student(
                "Stella",
                "Markova",
                new DateTime(1993, 11, 3),
                "From Vidin, gamer, high results, born at 03.11.1993");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
