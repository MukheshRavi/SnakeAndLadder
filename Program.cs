using System;

namespace snake_and_ladders
{
    class Program
    {
        public static int INITIAL = 0;
        public int rollingDie()
        {
            Random r = new Random();
            int dieNo = r.Next(7);
            return dieNo;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("die value returned is", new Program().rollingDie());
        }
    }
}
