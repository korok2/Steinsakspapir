using System;

namespace SteinSaksPapir
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "STEIN" && player != "SAKS" && player != "PAPIR")
                {
                    Console.Write("Velg STEIN, SAKS, eller PAPIR: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "STEIN";
                        break;
                    case 2:
                        computer = "SAKS";
                        break;
                    case 3:
                        computer = "PAPIR";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "STEIN":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Du tapte!");
                        }
                        else
                        {
                            Console.WriteLine("Du vant!");
                        }
                        break;
                    case "SAKS":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du tapte!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Du vant!");
                        }
                        else
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        break;
                    case "PAPIR":
                        if (computer == "STEIN")
                        {
                            Console.WriteLine("Du vant!");
                        }
                        else if (computer == "PAPIR")
                        {
                            Console.WriteLine("Uavgjort!");
                        }
                        else
                        {
                            Console.WriteLine("Du tapte!");
                        }
                        break;
                }

                Console.Write("Vil du spille igjen? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Takk for at du spillte!");

            Console.ReadKey();
        }
    }
}