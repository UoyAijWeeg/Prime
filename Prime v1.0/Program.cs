using System;

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
            int l; //N - 1
            
            s: Console.Clear();
            Console.WriteLine("Input a number [Inp]");
            inp = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            n = inp;

            d = 1;
            l = n - 1;

            re: if (d == l)
            {
                Console.WriteLine(n + " = Prime");
                Console.ReadLine();
                goto s;
            }

            d = d + 1;
            r = n % d;

            if (r == 0)
            {
                Console.WriteLine(n + " = Not Prime");
                Console.ReadLine();
                goto s;
            }else
            {
                goto re;
            }

        }
    }
}
