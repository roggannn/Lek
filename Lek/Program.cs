using System;

namespace något
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("");

                Console.WriteLine("[S]tarta spelet");

                Console.WriteLine("[H]ighscores");

                Console.WriteLine("[Q]uit");
                
                string val = Console.ReadLine();

                if (val == "S" || val == "s")
                {
                    
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("== VÄLKOMMEN TILL SPELET ==");
                    Console.WriteLine("");
                    Console.WriteLine("Här fortsätter du gissa tills du har lyckats med att gissa alla huvudstäder till alla länder i hela världen.");
                    Console.WriteLine("");

                    Console.WriteLine("Fortsätt genom att trycka på valfri knapp");
                    Console.ReadKey();
                    


                }
                if (val == "H" || val == "h")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("== HIGHSCORES ==");
                    Console.ReadKey();
                }
                if (val == "Q" || val == "q") 
                {
                    break;

                }



            }
          


        }


    }

}