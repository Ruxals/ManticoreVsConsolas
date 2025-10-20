using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreVsConsolas
{
    internal class Game
    {

        public Player player;
        public CPU cpu = new CPU();
        public bool HasWon(Player player, CPU cpu)
        {
            if(player.HP <= 0) { Console.WriteLine("Cpu Has WON!"); return true; }
            if(cpu.HP <= 0) { Console.WriteLine("Player Has WON!!"); return true;  }
            Console.WriteLine($"Player HP: {player.HP} Manticore HP: {cpu.HP}");
            return false;
        }

        public static int SetRange()
        {
            int range;
           
            bool valid = true;
            do
            {
                Console.WriteLine("Player where would you like the station from (0-100) meteres:");
                range = int.Parse(Console.ReadLine());

                if (range < 101) { valid = true; }
                else { valid = false; }

                switch (valid)
                {
                    case true:
                        Console.WriteLine($"The station is set at {range} meters! ");
                        return range;
                    default:
                        Console.WriteLine("Be sure to input the desired range Captain!!");
                        return 0;
                }
            } while (!valid);
        }

        public void Run()
        {
            SetRange();
            int count = 0;
            player = new Player(SetRange());
            int rangePrediction;
            do
            {
                Console.WriteLine("Determine where the Manticore can be from 0-100: ");
                rangePrediction = int.Parse(Console.ReadLine());

                HasWon(player,cpu);

                count++;
            } while (!(HasWon(player,cpu)));


        }
    }
}



