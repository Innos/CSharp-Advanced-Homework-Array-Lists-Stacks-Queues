using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ZeroSubset
{
    static void Main(string[] args)
    {
        int zeroSubsets = 0;
        int[] num = new int[5];
        Console.WriteLine("Input 5 integers each at a seperate line: ");
        for (int i = 0; i <num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < num.Length; i++)
        {
            for (int l = i+1; l < num.Length; l++)
            {
                int sumOf2 = num[i] + num[l];
                if(sumOf2 == 0)
                {
                    Console.WriteLine("{0}(#{2}) + {1}(#{3}) = 0",num[i],num[l],i+1,l+1);
                    zeroSubsets++;
                }
                for (int l1 = l + 1; l1 < num.Length; l1++)
                {
                    int sumOf3 = sumOf2 + num[l1];
                    if (sumOf3 == 0)
                    {
                        Console.WriteLine("{0}(#{3}) + {1}(#{4}) + {2}(#{5}) = 0", num[i], num[l], num[l1],i+1,l+1,l1+1);
                        zeroSubsets++;
                    }
                    for (int l2 = l1 + 1; l2 < num.Length; l2++)
                    {
                        int sumOf4 = sumOf3 + num[l2];
                        if (sumOf4 == 0)
                        {
                            Console.WriteLine("{0}(#{4}) + {1}(#{5}) + {2}(#{6}) + {3}(#{7}) = 0", num[i], num[l], num[l1], num[l2],i+1,l+1,l1+1,l2+1);
                            zeroSubsets++;
                        }
                        for (int l3 = l2 + 1; l3 < num.Length; l3++)
                        {
                            int sumOf5 = sumOf4 + num[l3];
                            if (sumOf5 == 0)
                            {
                                Console.WriteLine("{0}(#{5}) + {1}(#{6}) + {2}(#{7}) + {3}(#{8}) + {4}(#{9}) = 0", num[i], num[l], num[l1], num[l2], num[l3],i+1,l+1,l1+1,l2+1,l3+1);
                                zeroSubsets++;
                            }
                        }
                    }
                }
            }
        }
        if(zeroSubsets == 0)
        {
            Console.WriteLine("No zero subset");
        }
        else
        {
            Console.WriteLine("A total of {0} answers",zeroSubsets);
        }
    }
}

