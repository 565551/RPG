using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace RPG
{
    internal class Program
    {
        public static bool leave = false;
        public static string name = "";
        public static string path = "";
        string[] booses = {"Raticate", ""};
        public static bool Firstright;
        public static bool Firstleft;
        public static bool Haschosenpath = false;
        public static bool openChest = false;
        public static bool Hasopenedchest = false;
        public static string Swordtaken = "";
        public static string myPath ="";
        static void Main(string[] args)
        {
            output("What is your name?");

            name = Console.ReadLine();
            output("Your name is " + name);

            output("Hello " + name);
            output("You wake up in a mysterious hut in the middle of a forrest");
            output("You get up and start looking at you surroundings");
            output("While looking around you find a chest");

            output(@"
            _________________________________________________
            |                                               |
            |                                               |
            |                                               |
            |                                               |
            |              ____________________             |
            |              |                  |             |
            |              |        __        |             |
            |              |________||________|             |
            |              |¯¯¯¯¯¯¯¯||¯¯¯¯¯¯¯¯|             |
            |              |        ¯¯        |             |
            |              |                  |             |
            |              |                  |             |
            |              |__________________|             |
            |                                               |
            ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

            output("Do you open the chest? Y or N"); 
            string Openingchest = inputString();

            //output(Openingchest);

            if (Openingchest == "Y" || Openingchest == "y")
            {
                Hasopenedchest = true;
                openChest = true;
                output("opened");

            }
            else
            {
                output("closed");
            }

            //output("openChest="+ openChest);
    
            if (openChest == true)
            {
                output("You open the chest and you see");
                output(@"
                _________________________________________________
                |                                               |
                |                                  ██           |
                |                                ██             |
                |                              ██               |
                |                            ██                 |
                |                          ██                   |
                |                        ██                     |
                |              ██      ██                       |
                |                ██  ██                         |
                |                  ██                           |
                |                ██  ██                         |
                |              ██      ██                       |
                |            ██                                 |
                |                                               |
                ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

                output("You find a sword");
                output("Do you take the sword? Y or N");
                string Swordtaken = inputString();

                //output("Swordtaken=" + Swordtaken);

                if (Swordtaken == "Y" || Swordtaken == "y")
                {
                    output("You take the sword and carry it with you");
                }
            }
            else
            {
                output("You leave the sword in the chest");
            }

                Console.WriteLine("You see a door, do you leave? Y or N");

            do
            {

                string IsPlayerLeaving = inputYesNo();
                //IsPlayerLeaving = IsPlayerLeaving.ToLower();
                // Tolower() allows you to use any key as either a capital or lower case letter

                output("IsPlayerLeaving=" + IsPlayerLeaving);

                if (IsPlayerLeaving == "Y" || IsPlayerLeaving == "y")
                {
                    output("You exit the door");
                    leave = true;
                }
                else if (IsPlayerLeaving == "N" || IsPlayerLeaving == "n")
                {
                    output("An unknown force influences your mind making you curious about what lies beyond the door");
                    output("Do you enter? Y or N");
                }
                else
                {
                    output("Please only enter Y or N");
                }
            } while (leave == false);

                output("After you leave you see two paths");
            output("which path do you go down? L or R");

            myPath = inputString();
           
            while(Haschosenpath == false)
            {
                if (myPath == "R" || myPath == "r")
                {
                    Firstright = true;
                    Haschosenpath = true;
                }
                else if (myPath == "L" || myPath == "l")
                {
                    Firstleft = true;
                    Haschosenpath = true;
                }
                else
                {
                    output("Please only enter R or L");
                }
            }

            if (Firstright == true)
            {
                output("You go down the right path and you see a forest ahead of you");
                output("You start to walk into the forset and its quiet maybe too quiet");
                output("You start being more cautious");
                output("While you are walking you faintly hear a twig break, you are on edge now");
                output("Suddenly a massive snake lunges at you");
                output("what do you do?");
                output("");
            }
            if (Firstleft == true)
            {
                output("");
            }
        }
   
        public static void output (string input)
        {
            Console.WriteLine(input);
            Thread.Sleep(500);
        }
        public static string inputString()
        {
            string input;
            input = Console.ReadLine();
            return input;
        }

        public static string inputYesNo()
        {
            string inputOption = ""; 
            bool isValid = false;
            
            while (isValid == false)
            {
                output("input selection");
                inputOption = Console.ReadLine();
                inputOption = inputOption.Substring(0, 1);
                inputOption = inputOption.ToUpper();
                if ((inputOption == "Y") || (inputOption == "N"))
                {
                     isValid = true;

                }
                else
                {
                    output("invalid selection");
                }
            }

            return inputOption;

        }

        public static int inputNumber()
        {
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    } // you missed this
}
