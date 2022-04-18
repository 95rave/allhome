using System;

namespace sumtask2
{
    class Program
    {
        static int Getsum(int x )

        {
            int sum = 0;

            while (x != 0)
            {
                sum = sum + x % 10;
                x = x / 10;

            }
            return sum;
        }
        public static void Main()
        {
            int x = 1995;
            Console.Write(Getsum(x));
        }
    }    


          
}
