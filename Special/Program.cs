using System;
using System.Threading;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence:");
            int input_num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetSpecial(input_num)}");
        }
        private static int GetSpecial(int n)
        {
            int spec_num;
            if (n == 0)
            {
               spec_num = 0; 
            }
            else if (n == 1)
            {
                spec_num = 1;
            }
            else
            {
                spec_num = GetSpecial(n-1) + (2 * GetSpecial(n-2));
            }
            return spec_num;
        }
    }
}
