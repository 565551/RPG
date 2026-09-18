namespace RPG
{
    internal class Program
    {
        public static bool leave = false;
        public static string name = "";
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You wake up in a mysterious forest");
            Console.WriteLine("You get up and start looking around and you see a door, do you leave? Y or N");

            while (!leave)
            {
                string IsPlayerLeaving = Console.ReadLine();
                IsPlayerLeaving.ToLower(); // Tolower() allows you to use any key as either a capital or lower case letter

                if (IsPlayerLeaving == "Y" || IsPlayerLeaving == "y")
                {
                    Console.WriteLine("You exit the door");
                    leave = true;
                }
                else if (IsPlayerLeaving == "N" || IsPlayerLeaving == "n")
                {
                    Console.WriteLine("An unknown force influences your mind making you curious about what lies beyond the door");
                    Console.WriteLine("Do you enter? Y or N");
                }
                else
                {
                    Console.WriteLine("Please only enter Y or N");
                }
            }
            Console.WriteLine("After you leave you see two paths");


        }
    }// you missed this
}
