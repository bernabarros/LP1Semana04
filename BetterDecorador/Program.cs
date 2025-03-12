using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],char.Parse(args[1]), 
            int.Parse(args[2])));
        }
        private static string Decor(string s, char dec, int input_num)
        {
            int num = 0;
            s = " " + s + " ";
            while(num != input_num)
            {
                s = dec + s + dec;
                ++num;
            }
            return s;
        }
    }
}
