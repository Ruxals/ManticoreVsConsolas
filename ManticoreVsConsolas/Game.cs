using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ManticoreVsConsolas
{
    internal class Game
    {
        public Player player = new Player();
        public CPU cpu = new CPU();
        public Canon canon = new Canon();
        public bool found = false;
        public bool HasWon(Player player, CPU cpu)
        {
            if(player.HP <= 0) { Console.WriteLine("Manticore Has WON!"); return true; }
            if(cpu.HP <= 0) { Console.WriteLine("Player Has WON!!"); return true;  }
            Console.WriteLine($"Player HP: {player.HP} Manticore HP: {cpu.HP}");
            return false;
        }
        public void HasFound(Player player, CPU cpu, int count)
        {
            int damage;

            if (player.Range == cpu.Range)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player you have hit the Manticore! Continue to steady here! \n"); 
                damage = canon.RoundType(count);
                Console.ForegroundColor = ConsoleColor.White; 
                cpu.Damage(damage*5);
            }
            if (player.Range < cpu.Range)
            {
                Console.ForegroundColor = ConsoleColor.Red;
         
                Console.WriteLine("Captain our canon shot too short in range of the Manticore\n");
                player.Damage(5);
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (player.Range > cpu.Range) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Captain our canon shot too far in range of the Manticore\n");
                player.Damage(5);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static int SetRange(Player player)
        {
            int range;

            bool valid = true;
            do
            {
                Console.WriteLine("Player where would you like the canon set from (0-100) meteres of the Manticore's location\n");
                range = int.Parse(Console.ReadLine());

                if (range < 101) { valid = true; }
                else { valid = false; }

                switch (valid)
                {
                    case true:
                        Console.WriteLine($"The canon has shot at {range} meters!");
                        Console.WriteLine();
                        return range;
                    default:
                        Console.WriteLine("Be sure to input the desired range Captain!!");
                        Console.WriteLine();
                        return 0;
                }
            } while (!valid);
        }
        public void Run()
        {
            int count = 0;
            bool hasWon = false;
            int range;
            do
            { 
                range = SetRange(player);
                player.Range = range;
                HasFound(player, cpu,count);
                hasWon = HasWon(player,cpu);
                count++;
            } while (!hasWon);

        }
    }
}



