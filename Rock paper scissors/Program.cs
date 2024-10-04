using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            while (enemyScore< 20 && playerScore < 20)
            {
                Console.WriteLine("Hello player welcome our rock paper scissor game");
                Console.WriteLine(" if you wanna do rock tpye 'r' if you wanna do paper type 'p' if you wanna do scissor type 's' ");
                string PlayerChoice = Console.ReadLine();
                int enemyChoice = random.Next(0,3);
                

                if (enemyChoice == 0)
                {
                    Console.WriteLine("enemy chooses rock");

                    switch (PlayerChoice)
                    {
                        case "r":
                            Console.WriteLine("tie");
                            break;
                        case "p":
                            Console.WriteLine("Player wins");
                            playerScore = playerScore + 5;
                            break;
                        default:
                            Console.WriteLine("enemy wins");
                            enemyScore = enemyScore + 5;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("enemt chooses paper");

                    switch (PlayerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins");
                            enemyScore += 5;
                            break;
                        case "p":
                            Console.WriteLine("tie");
                            break;
                        default :
                            Console.WriteLine("player wins");
                            playerScore += 5;
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("enemy chooses scssiors.");
                    switch (PlayerChoice)
                    {
                        case "r":
                            Console.WriteLine("player wins");
                            playerScore += 5;
                            break;
                        case "p":
                            Console.WriteLine("enemy wins");
                            enemyScore += 5;
                            break;
                        default:
                            Console.WriteLine("tie");
                            break;
                    }
                }
            }
            if (playerScore == 20)
            {
                Console.WriteLine("Player win");
            }
            else
            {
                Console.WriteLine("enemy win");
            }
            Console.ReadKey();
        }
    }
}
