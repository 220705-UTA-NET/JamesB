//Testing SonarCloud

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace P0_mud
{
    class Program
    {

        static void Main()
        {
            try { Console.Clear(); }
            catch { }
            
            Console.WriteLine("\n\nWelcome to the Border of many lands\n\n");
           
           gameMenu newgame = new gameMenu();
           newgame.menu();

            
            // warrior character2 = new warrior();
            // Console.WriteLine("Warrior");
            // Console.WriteLine("Hit Points " + character2.getCurrentHP());
            // Console.WriteLine("Attack Bonus " + character2.getAttBonus());
            // Console.WriteLine("Save Bonus " + character2.getSaveBonus());

            // Console.WriteLine("");

            // mage character3 = new mage();

            // Console.WriteLine("Mage");
            // Console.WriteLine("Hit Points " + character3.getCurrentHP());
            // Console.WriteLine("Attack Bonus " + character3.getAttBonus());
            // Console.WriteLine("Save Bonus " + character3.getSaveBonus());

            // Console.WriteLine("");

            // NPC gobs = new NPC(16, 2, 2);

            // Console.WriteLine("Goblin");
            // Console.WriteLine("Hit Points " + gobs.getCurrentHP());
            // Console.WriteLine("Attack Bonus " + gobs.getAttBonus());
            // Console.WriteLine("Save Bonus " + gobs.getSaveBonus());

            // Console.WriteLine("Movement Function Test");

            // Console.WriteLine("Good Movement Test");

            // Navigation mv = new Navigation();                   
            // int[] cursor = new int[2];
            // cursor = mv.Move();

            
            // Console.WriteLine(cursor[0] + " : " + cursor[1]);

            
            // Console.WriteLine("Movement Function Test");

            // Console.WriteLine("Bad input Movement Test");

            // cursor = mv.Move();
            
            // Console.Write(cursor[0] + " : " + cursor[1]);


        }
        
    }

}
