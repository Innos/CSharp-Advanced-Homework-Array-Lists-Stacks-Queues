using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixTests
{
    using System.IO;
    using System.Text;

    [TestClass]
    public class MatrixTraversalTests
    {
        [TestMethod]
        public void TestMatrixTraversalWithSizeNinety_ShouldReturnCorrectMatrix()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test0Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test0Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal printed an incorrect output!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithSizeSix_ShouldReturnCorrectMatrix()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
          
                using (FileStream fs = new FileStream("../../Test1Input.txt",FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test1Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected,sw.ToString(),"MatrixTraversal printed an incorrect output!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithSizeFifteen_ShouldReturnCorrectMatrix()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test2Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test2Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal printed an incorrect output!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithSizeMinusOne_ShouldReturnIncorrectInputMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test3Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test3Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal did not display an incorrect input message!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithSize101_ShouldReturnIncorrectInputMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test4Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test4Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal did not display an incorrect input message!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithLetterInput_ShouldReturnIncorrectInputMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test5Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test5Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal did not display an incorrect input message!");
            }
        }

        [TestMethod]
        public void TestMatrixTraversalWithSizeZero_ShouldReturnIncorrectInputMessage()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (FileStream fs = new FileStream("../../Test6Input.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        Console.SetIn(sr);
                        MatrixTraversal.RotatingMatrixTraversal.Main();
                    }
                }

                string expected;
                using (FileStream fs = new FileStream("../../Test6Output.txt", FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        expected = sr.ReadToEnd();
                    }
                }

                Assert.AreEqual(expected, sw.ToString(), "MatrixTraversal did not display an incorrect input message!");
            }
        }

    }
}
