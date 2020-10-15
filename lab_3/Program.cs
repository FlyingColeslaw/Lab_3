using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)

          

        {
            bool isLooping = true;

        Console.WriteLine( "Enter your name");
            string userName = Console.ReadLine();

            while (isLooping)

            {

                Console.WriteLine(userName + ", Enter a number between 1 and 100");
                double Numbre = double.Parse(Console.ReadLine());
                {
                    bool theEven = Numbre % 2 == 0;
                    bool theOdd = Numbre % 2 != 0;
                    bool theSmall = Numbre < 25 && Numbre > 1;
                    bool theMedium = Numbre > 25 && Numbre < 61;
                    bool theLarge = Numbre > 59 && Numbre < 101;
                    bool theWrong = Numbre < 1 || Numbre > 100;
                    bool theRange = Numbre > 0 && Numbre < 101;

                    bool evenzSmall = theEven && theSmall;
                    bool evenzMedium = theEven && theMedium;
                    bool evenzLarge = theEven && theLarge;
                    bool oddzRule = theOdd && theRange;

                    {
                        if (evenzSmall)
                        {
                            Console.WriteLine("Even and less than 25");
                        }

                        else if (oddzRule)
                        {
                            Console.WriteLine(Numbre + " and odd");
                        }
                        else if (evenzMedium)
                        {
                            Console.WriteLine("Even");
                        }
                        else if (evenzLarge)
                        {
                            Console.WriteLine(Numbre + " and Even");
                        }
                        else if (theWrong)
                        {
                            Console.WriteLine(userName + " pleae enter number 1-100");
                        }

                        Console.WriteLine(userName + ", Continue? (y/n)");
                        string userLoopInput = Console.ReadLine();

                        if (userLoopInput.Equals("y"))
                        {
                           
                        
                        continue;     
                            
                        }
                        else

                        {
                        isLooping = false;
                        }
                    }
                }
            }
        }
    }
}
