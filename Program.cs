using System;

namespace Rekursiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Fakultät(15));
            Console.ReadKey();
        }
        private static Int64 Fakultät(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Fakultät(n - 1);
        }
    }
}
