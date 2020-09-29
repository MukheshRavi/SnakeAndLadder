using System;

namespace snake_and_ladders
{
    class Program
    {
        public static int INITIAL = 0;
        public int rollingDie()
        {
            Random r = new Random();
            int dieNo = r.Next(1,7);
            return dieNo;
        }
        public void option()
        {
            int position = 0;
            
            int noOfTurns = 0;
            while(position<100)
            {
                noOfTurns++;
                int dieNo = new Program().rollingDie();
                Random r = new Random();
                int option = r.Next(3);
                
                switch (option)
                {
                    case 0:
                        position = INITIAL + position;
                        break;
                    case 1:
                        position = position + dieNo;
                        break;
                    case 2:
                        position = position - dieNo;

                        break;
                    default:
                        break;
                }

                if (position < 0)
                    position = INITIAL;
                if (position > 100)
                    position = position - dieNo;

                Console.WriteLine("The player took" + noOfTurns + "  turns to reach position" + position);
            }

           

        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.option();
        }
    }
}
