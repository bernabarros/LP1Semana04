using System;
using System.Threading;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetSpecial(n)}");
        }
        private static int GetSpecial(int n)
        {
            int [] spec_seq = new int [11] {0,1,1,3,5,11,21,43,85,171,341};
            int spec_num = 0;
            if(n != 1)
            {
                spec_num = GetSpecial(n-1) + (2 * spec_seq[n-2]);
            }
            else
            spec_num += 1;
            return spec_num;
        }
    }
}
