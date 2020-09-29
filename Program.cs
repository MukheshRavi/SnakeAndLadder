using System;

namespace snake_and_ladders
{
    class Program
    {
        public static int INITIAL = 0;
        public int rollingDie()
        {
            Random r = new Random();
            int dieNo = r.Next(1, 7);
            return dieNo;
        }
        public void option()
        {
            
            int position1 = 0;
            int position2 = 0;
            int noOfTurns1 = 0;
            int noOfTurns2 = 0;
            
            string chance = "player1";


            while (position1 < 100 && position2<100)
            {
                
                int dieNo = new Program().rollingDie();
                Random r = new Random();
                int option = r.Next(3);
                if(chance=="player1")
                {
                    noOfTurns1++;
                    switch (option)
                {
                    case 0:
                        position1 = INITIAL + position1;
                        break;
                    case 1:
                        position1 = position1 + dieNo;
                        break;
                    case 2:
                        position1 = position1 - dieNo;

                        break;
                    default:
                        break;
                }

                if (position1 < 0)
                    position1 = INITIAL;
                if (position1 > 100)
                    position1 = position1 - dieNo;
                
                   
                   
                    Console.WriteLine("The " + chance + " took" + noOfTurns1 + "  turns to reach position" + position1);
                   
                    
                    chance = "player2";
                    if (option == 1)
                        chance = "player1";
                    
                }
                else
                {
                        noOfTurns2++;
                        switch (option)
                        {
                            case 0:
                                position2 = INITIAL + position2;
                                break;
                            case 1:
                                position2 = position2 + dieNo;
                                break;
                            case 2:
                                position2 = position2 - dieNo;

                                break;
                            default:
                                break;
                        }

                        if (position2 < 0)
                            position2 = INITIAL;
                        if (position2 > 100)
                            position2= position2 - dieNo;



                        Console.WriteLine("The " + chance + " took" + noOfTurns2+ "  turns to reach position" + position2);


                        chance = "player1";
                    if (option == 1)
                        chance = "player2";
                }

               
            }
        }






        static void Main(string[] args)
        {
            Program p = new Program();
            p.option();
        }
    }
    }

