using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1436_MovieDerectorShom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32 count = 0;
            Int32 start = 666;

            while (true)
            {
                if (count >= n)
                    break;

                String sLen = Convert.ToString(start);
                for (Int32 i = 0; i < sLen.Length - 2; i++)
                {
                    if (sLen[i] == '6')
                    {
                        if (sLen[i] == '6' && sLen[i + 1] == '6' && sLen[i + 2] == '6')
                        {
                            count++;
                            break;
                        }
                    }
                }
                if(count < n)
                    start++;
            }

            Console.WriteLine(start);
        }
    }
}
