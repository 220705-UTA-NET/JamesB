using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.DTO;



namespace Actions
{
    public class Menu
    {
        //fields of data
        private string player_name = "Player 1";
        private char menu_choice = ' ';
        private bool loop = true;
        Player player_Data = new Player();
        Character player_Character = new Character();

        //construction stuff
        public Menu()
        {
            main_Menu();
        }


        public void main_Menu()
        { 
            Console.Clear();
            Console.WriteLine("Who are you? Please enter your Player Name");

            try
            {
                player_name = Console.ReadLine();
            }
            catch
            {
                
            }

            while (loop)
            {
                Console.WriteLine("Please select an option below:");
                Console.WriteLine("1: Start new game");
                Console.WriteLine("2: Load Previous Game");
                Console.WriteLine("5: Delete Previous Save");
                Console.WriteLine("0: Exit the Program");
                Console.WriteLine("\n\n");

                menu_choice = Console.ReadKey().KeyChar;

                //menu_choice = char.ToUpper(menu_choice);
                Console.Clear();

            
                switch (menu_choice)
                {
                    case '1':
                        new_Game();
                        break;
                    case '2':
                        load_Game();
                        break;
                    case '5':
                        delete_Game();
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("That isn't a valid answer. Common now hero, Stop playing around.");
                        break;
                }
                    
            } 
                 
           

        }

        //methods of madness

        internal void new_Game()
        {
            Console.WriteLine("New to the Border of Many Lands huh." +
                "\n Lets make you a new character." +
                "\n Would you like to be a Warrior or a Mage\n");
            
            while (loop)
            {
                print_Char_Creation();
                menu_choice = char.ToUpper(Console.ReadKey().KeyChar);

                switch (menu_choice)
                {
                    case 'W':
                        player_Character.create(15, 5, 3, 8);
                        loop = false;
                        break;
                    case 'M':
                        player_Character.create(8, 7, 7, 12);
                        loop = false;
                        break;
                    case 'R':
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("That isn't a valid input.\n");
                        break;
                }
            }
            loop = true;
            
            Console.WriteLine("Character Created:" +
                "\n Please give your new Character a name.");
            try { player_Character.name = Console.ReadLine(); }
            catch { }

        }

        internal void load_Game()
        {

        }

        internal void delete_Game()
        {

        }

        internal void print_Char_Creation()
        {
            Console.WriteLine("\nPress W for Warrior" +
                "\n Press M for Mage" +
                "\n Press R to Return to Main Menu");
            return;
        }
    }
}
