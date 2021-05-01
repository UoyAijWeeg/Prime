using System;
using System.Diagnostics;
using System.Threading;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp; //Input
            int d; //Divide
            int r; //Remainder
            int n; //Number
            int l; //N - 1 (Limit)
            int c; //Count
            int e; //End
            int p = 0; //Prime Count
            int np = 0; //NotPrime Count
            string result2 = "";
            string result3 = "";
            Console.WriteLine("Input a end number [Inp]");
            inp = Convert.ToInt32(Console.ReadLine());
            c = 0;
            e = inp;
            DateTime dt1 = DateTime.Now;

            s: c = c + 1;
            n = c + 1;

            if (c == e)
            {
                goto end;
            }else 
            {
                d = 1;
                l = n - 1;
    
                re: if (d == l)
                {
                    Console.WriteLine(n + " = Prime");
                    p = p + 1;
                    goto s;
                }
    
                d = d + 1;
                r = n % d;
    
                if (r == 0)
                {
                    Console.WriteLine(n + " = Not Prime");
                    np = np + 1;
                    goto s;
                }else
                {
                    goto re;
                }
            }
            end: np = np + 1;
            DateTime dt2 = DateTime.Now;
            TimeSpan result = dt2.Subtract(dt1);
            result2 = Convert.ToString(result);
            result3 = result2.Split('.')[0].Trim();
            Console.WriteLine("Prime = " + p);
            Console.WriteLine("Not Prime = " + np);
            Console.WriteLine("Time taken: " + result3);
            Console.ReadLine();            
        }
    }
}