using Actions;
using API_Connection;

namespace RPG_P1
{

    class Program
    {

        static async Task Main()
        {

            Console.Clear();
            string textToEnter = "Welcome to the Border of many Lands";
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            textToEnter = "Press a key to continue";

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.ReadKey();

            //Actions.Menu gameStart = new Actions.Menu();

            //CharacterRetrival actor = new CharacterRetrival();

            //await actor.GetCharacter();

            textToEnter = "Ok... That was a pretty title screen James.";

            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            textToEnter = "But we both know that this console is dead.";
            Console.WriteLine("\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            textToEnter = "Press A Key to Close";
            Console.WriteLine("\n\n");
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

        }

    }


}



