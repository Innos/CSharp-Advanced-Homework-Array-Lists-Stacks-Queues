namespace _02PerformanceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    class PerformanceOfOperations
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        static void Main()
        {
            List<TimeSpan> intAddTimes = new List<TimeSpan>();
            List<TimeSpan> longAddTimes = new List<TimeSpan>();
            List<TimeSpan> floatAddTimes = new List<TimeSpan>();
            List<TimeSpan> doubleAddTimes = new List<TimeSpan>();
            List<TimeSpan> decimalAddTimes = new List<TimeSpan>();

            List<TimeSpan> intSubtractTimes = new List<TimeSpan>();
            List<TimeSpan> longSubtractTimes = new List<TimeSpan>();
            List<TimeSpan> floatSubtractTimes = new List<TimeSpan>();
            List<TimeSpan> doubleSubtractTimes = new List<TimeSpan>();
            List<TimeSpan> decimalSubtractTimes = new List<TimeSpan>();

            List<TimeSpan> intPreIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> longPreIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> floatPreIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> doublePreIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> decimalPreIncrementTimes = new List<TimeSpan>();

            List<TimeSpan> intPostIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> longPostIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> floatPostIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> doublePostIncrementTimes = new List<TimeSpan>();
            List<TimeSpan> decimalPostIncrementTimes = new List<TimeSpan>();

            List<TimeSpan> intShorthandAddTimes = new List<TimeSpan>();
            List<TimeSpan> longShorthandAddTimes = new List<TimeSpan>();
            List<TimeSpan> floatShorthandAddTimes = new List<TimeSpan>();
            List<TimeSpan> doubleShorthandAddTimes = new List<TimeSpan>();
            List<TimeSpan> decimalShorthandAddTimes = new List<TimeSpan>();

            List<TimeSpan> intMultiplyTimes = new List<TimeSpan>();
            List<TimeSpan> longMultiplyTimes = new List<TimeSpan>();
            List<TimeSpan> floatMultiplyTimes = new List<TimeSpan>();
            List<TimeSpan> doubleMultiplyTimes = new List<TimeSpan>();
            List<TimeSpan> decimalMultiplyTimes = new List<TimeSpan>();

            List<TimeSpan> intDivideTimes = new List<TimeSpan>();
            List<TimeSpan> longDivideTimes = new List<TimeSpan>();
            List<TimeSpan> floatDivideTimes = new List<TimeSpan>();
            List<TimeSpan> doubleDivideTimes = new List<TimeSpan>();
            List<TimeSpan> decimalDivideTimes = new List<TimeSpan>();

            List<TimeSpan> floatSquareRootTimes = new List<TimeSpan>();
            List<TimeSpan> doubleSquareRootTimes = new List<TimeSpan>();
            List<TimeSpan> decimalSquareRootTimes = new List<TimeSpan>();

            List<TimeSpan> floatLogarithmTimes = new List<TimeSpan>();
            List<TimeSpan> doubleLogarithmTimes = new List<TimeSpan>();
            List<TimeSpan> decimalLogarithmTimes = new List<TimeSpan>();

            List<TimeSpan> floatSineTimes = new List<TimeSpan>();
            List<TimeSpan> doubleSineTimes = new List<TimeSpan>();
            List<TimeSpan> decimalSineTimes = new List<TimeSpan>();


            for (int i = 0; i < 500; i++)
            {
                TestAdd(intAddTimes, longAddTimes, floatAddTimes, doubleAddTimes, decimalAddTimes);
                TestSubtract(intSubtractTimes, longSubtractTimes, floatSubtractTimes, doubleSubtractTimes, decimalSubtractTimes);
                TestPreIncrement(intPreIncrementTimes, longPreIncrementTimes, floatPreIncrementTimes, doublePreIncrementTimes, decimalPreIncrementTimes);
                TestPostIncrement(intPostIncrementTimes, longPostIncrementTimes, floatPostIncrementTimes, doublePostIncrementTimes, decimalPostIncrementTimes);
                TestShorthandAdd(intShorthandAddTimes, longShorthandAddTimes, floatShorthandAddTimes, doubleShorthandAddTimes, decimalShorthandAddTimes);
                TestMultiply(intMultiplyTimes, longMultiplyTimes, floatMultiplyTimes, doubleMultiplyTimes, decimalMultiplyTimes);
                TestDivide(intDivideTimes, longDivideTimes, floatDivideTimes, doubleDivideTimes, decimalDivideTimes);

                TestSquareRoot(floatSquareRootTimes,doubleSquareRootTimes, decimalSquareRootTimes);
                TestLogarithm(floatLogarithmTimes,doubleLogarithmTimes, decimalLogarithmTimes);
                TestSine(floatSineTimes,doubleSineTimes, decimalSineTimes);
            }

            //Storing results
            using (var fs = new FileStream("SimpleOperations.txt",FileMode.Create))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.WriteLine("n=500\tInt\tLong\tFloat\tDouble\tDecimal");
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}","+",intAddTimes.Average(x=>x.Ticks),longAddTimes.Average(x=>x.Ticks),floatAddTimes.Average(x=>x.Ticks),doubleAddTimes.Average(x=>x.Ticks),decimalAddTimes.Average(x=>x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "-", intSubtractTimes.Average(x => x.Ticks), longSubtractTimes.Average(x => x.Ticks), floatSubtractTimes.Average(x => x.Ticks), doubleSubtractTimes.Average(x => x.Ticks), decimalSubtractTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "++(pre)", intPreIncrementTimes.Average(x => x.Ticks), longPreIncrementTimes.Average(x => x.Ticks), floatPreIncrementTimes.Average(x => x.Ticks), doublePreIncrementTimes.Average(x => x.Ticks), decimalPreIncrementTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "++(post)", intPostIncrementTimes.Average(x => x.Ticks), longPostIncrementTimes.Average(x => x.Ticks), floatPostIncrementTimes.Average(x => x.Ticks), doublePostIncrementTimes.Average(x => x.Ticks), decimalPostIncrementTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "+=", intShorthandAddTimes.Average(x => x.Ticks), longShorthandAddTimes.Average(x => x.Ticks), floatShorthandAddTimes.Average(x => x.Ticks), doubleShorthandAddTimes.Average(x => x.Ticks), decimalShorthandAddTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "*", intMultiplyTimes.Average(x => x.Ticks), longMultiplyTimes.Average(x => x.Ticks), floatMultiplyTimes.Average(x => x.Ticks), doubleMultiplyTimes.Average(x => x.Ticks), decimalMultiplyTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "/", intDivideTimes.Average(x => x.Ticks), longDivideTimes.Average(x => x.Ticks), floatDivideTimes.Average(x => x.Ticks), doubleDivideTimes.Average(x => x.Ticks), decimalDivideTimes.Average(x => x.Ticks));
                }     
            }

            using (var fs = new FileStream("ComplexOperations.txt", FileMode.Create))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.WriteLine("n=500\tFloat\tDouble\tDecimal");
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}", "Math.Sqrt",floatSquareRootTimes.Average(x=>x.Ticks),  doubleSquareRootTimes.Average(x => x.Ticks), decimalSquareRootTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}", "Math.Log", floatSquareRootTimes.Average(x => x.Ticks), doubleLogarithmTimes.Average(x => x.Ticks), decimalLogarithmTimes.Average(x => x.Ticks));
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}", "Math.Sin", floatSquareRootTimes.Average(x => x.Ticks), doubleSineTimes.Average(x => x.Ticks), decimalSineTimes.Average(x => x.Ticks));
                }
            }
        }

        static void TestAdd(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest = intTest + 2;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest = longTest + 2;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = floatTest + 2;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = doubleTest + 2;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest = decimalTest + 2;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestSubtract(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest = intTest - 2;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest = longTest - 2;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = floatTest - 2;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = doubleTest - 2;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest = decimalTest - 2;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestPreIncrement(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                ++intTest;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                ++longTest;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                ++floatTest;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                ++doubleTest;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                ++decimalTest;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestPostIncrement(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest++;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest++;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest++;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest++;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest++;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestShorthandAdd(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest += 2;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest += 2;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest += 2;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest += 2;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest += 2;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestMultiply(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest = intTest * 1;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest = longTest * 1;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = floatTest * 1;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = doubleTest * 1;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest = decimalTest * 1;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestDivide(List<TimeSpan> intTimes, List<TimeSpan> longTimes, List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Int test
            int intTest = 1000000;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                intTest = intTest / 2;
            }

            intTimes.Add(Stopwatch.Elapsed);

            //Long test
            long longTest = 1000000;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                longTest = longTest / 2;
            }

            longTimes.Add(Stopwatch.Elapsed);

            //Float test
            float floatTest = 1000000;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = floatTest / 2;
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 1000000;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = doubleTest / 2;
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 1000000;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                decimalTest = decimalTest / 2;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestSquareRoot(List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Float test
            float floatTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = (float)Math.Sqrt(floatTest);
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = Math.Sqrt(doubleTest);
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 1;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                //Math.Sqrt does not have an overload for decimal
                decimalTest = (decimal)Math.Sqrt((double)decimalTest);
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestLogarithm(List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = (float)Math.Log(15);
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = Math.Log(15);
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                //Math.Log does not have an overload for decimal
                decimalTest = (decimal)Math.Log(15);;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

        static void TestSine(List<TimeSpan> floatTimes, List<TimeSpan> doubleTimes, List<TimeSpan> decimalTimes)
        {
            //Float test
            float floatTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                floatTest = (float)Math.Sin(30);
            }

            floatTimes.Add(Stopwatch.Elapsed);

            //Double test
            double doubleTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                doubleTest = Math.Sin(30);
            }

            doubleTimes.Add(Stopwatch.Elapsed);

            //Decimal test
            decimal decimalTest = 0;
            Stopwatch.Restart();
            for (int i = 0; i < 5000; i++)
            {
                //Math.Sin does not have an overload for decimal
                decimalTest = (decimal)Math.Sin(30); ;
            }

            decimalTimes.Add(Stopwatch.Elapsed);
        }

    }
}
