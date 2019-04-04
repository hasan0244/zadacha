using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
                       int health = int.Parse(Console.ReadLine());
            int originalhealth = health;
            string virus = Console.ReadLine();
            var encountered = new Dictionary<string, int>();
            string previousvirus = string.Empty;
            while (true)
            {
                if (encountered.ContainsKey(virus)) encountered[virus] += 1;
                else encountered[virus] = 1;
                int power = 0;
                foreach (var ch in virus)
                    power += (int)ch;
                power /= 3;
                int time = power * virus.Length;
                if (encountered[virus] > 1 && previousvirus != virus) time /= 3;
                health -= time;
                Console.WriteLine("Virus {0}: {1} => {2} seconds",virus,power,time);
                if (health <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} defeated in {1}m {2}s.",virus,time/60,time%60);
                    Console.WriteLine("Remaining health: {0}",health);
                    health = health + (health * 20) / 100;
                    if (health > originalhealth) health = originalhealth;
                }
                previousvirus = virus;
                virus = Console.ReadLine();
                if (virus == "end")
                {
                    Console.WriteLine("Final Health: {0}",health);
                    break;
                }
            }




        }
    }
}
