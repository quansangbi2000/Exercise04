using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello github");
        }
        public static bool IsOdd(int n)
        {
            return false;
        }
        public static bool IsEven(int n)
        {
            return true;
        }
        //input : float x
        //output : a int that smallest but not smaller than x
        //idea : first  change float x into integer then ++1
        //     : if x is a negative then unchanged
        //     : if x == n then return x
        public static int Ceil(float x)
        {
            int n = (int)x;
            if (x != n)
               if (x > 0)
                   n = n + 1;
            return n;
        }
        //input : float x
        //output : a int that largest but not greater than x
        //idea : first change float x into integer
        //     : if x is a negative then --1
        //     : if x == i then unchange
        public static int Floor(float x)
        {
            int i = (int)x;
            if ( x < 0)
            {
                if( i != x )
                {
                    i = i - 1;
                }
            }
            return i;
        }
    }
}
