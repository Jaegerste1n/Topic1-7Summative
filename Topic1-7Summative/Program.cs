using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

namespace Topic1_7Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int beginChoice;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to Big Stinker Casino. Due to budget cuts and corporate espionage, we only have Rock Paper Scissors.");
            Console.WriteLine("");
            Console.WriteLine("This is Jim. He won the Rock Paper Schampion trophy back in '07.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("I'm Jim");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Are you ready?");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) Forfeit instantly");
            Console.WriteLine("(Enter a number)");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out beginChoice);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (beginChoice == 1)
            {
                
                RPS();
            }
            else if (beginChoice == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("What? Dude");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Can't even enter a valid option? get out of my casino.");
            }
        }

        public static void RPS()
        {
            Console.Clear();
            Random generator = new Random();

            int bet, outcome, account = 20000;
            int computerChoice, playerChoice, winnings, duelCount = 0;
            bool quit = false;
            computerChoice = generator.Next(10);

            while (!quit)
            {
                Console.Clear();
                if (account <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You've gone broke!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Final balance: $" + account);
                    Console.WriteLine("Final round: " + duelCount);
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("1) Okay");
                    Console.WriteLine("2) No No No No No No");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    int.TryParse(Console.ReadLine(), out playerChoice);
                    if (playerChoice == 1)
                    {
                        RPS();
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You remember that Big Stinker Casino stinks.");
                        quit = true;
                        Console.ReadLine();
                            end();
                    }

                }
                outcome = 0;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                duelCount++;
                Console.WriteLine("The wheel of fate keeps turning!");
                Console.WriteLine("            DUEL " + duelCount + "!             ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Stake your bet!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Balance: $" + account);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                int.TryParse(Console.ReadLine(), out bet);
                if (bet == account)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("He's all in!");
                }
                else if (bet > account || bet <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Invalid bet. Automatically set to ALL IN.");
                    bet = account;
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Bet: $" + bet);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Make your choice. (enter a number)");
                computerChoice = generator.Next(1, 4);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("1) Rock");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("2) Paper");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3) Scissors");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("4) Quit");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                int.TryParse(Console.ReadLine(), out playerChoice);
                if (playerChoice == 4)
                {
                    Console.Clear();
                    quit = true;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Suddenly, everything goes dark.");
                    Console.WriteLine("Final balance: $" + account);
                    Console.WriteLine("Final round: " + duelCount);
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play again?");
                    Console.WriteLine("1) Okay");
                    Console.WriteLine("2) No No No No No No");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    int.TryParse(Console.ReadLine(), out playerChoice);
                    if (playerChoice == 1)
                    {
                        RPS();
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You remember that Big Stinker Casino stinks.");
                        quit = true;
                    }
                }
                else if (playerChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You chose...");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Rock!");
                }
                else if (playerChoice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You chose...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Paper!");
                }
                else if (playerChoice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You chose...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Scissors!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Invalid. Automatically set to Rock.");
                    playerChoice = 1;
                }
                if (!quit)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Jim chose...");
                    if (computerChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Rock!");
                    }
                    else if (computerChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Paper!");
                    }
                    else if (computerChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Scissors!");
                    }
                    Console.WriteLine("");
                    if (playerChoice == computerChoice)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("They tied!");
                    }
                    else if (playerChoice == 1 && computerChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You lost!");
                        outcome = 2;
                    }
                    else if (playerChoice == 2 && computerChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You lost!");
                        outcome = 2;
                    }
                    else if (playerChoice == 3 && computerChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You lost!");
                        outcome = 2;
                    }
                    else if (playerChoice == 3 && computerChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        outcome = 1;
                    }
                    else if (playerChoice == 1 && computerChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        outcome = 1;
                    }
                    else if (playerChoice == 2 && computerChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        outcome = 1;
                    }
                    if (outcome == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        winnings = (int)(bet * 1.5);
                        Console.WriteLine("Winnings: $" + winnings);
                        account = (account + winnings);
                    }
                    else if (outcome == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        winnings = (int)(bet * 0.98 - 80);
                        account = (account - (winnings + 80));
                        Console.WriteLine("Lost: $" + (int)(winnings + 80));
                        
                        
                    }
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Continue?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1) Let It Ride!");
                    Console.WriteLine("2) Chicken Out");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    int.TryParse(Console.ReadLine(), out playerChoice);
                    if (playerChoice == 1)
                    {
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Coward!");
                        Console.WriteLine("Final balance: $" + account);
                        Console.WriteLine("Final round: " + duelCount);
                        quit = true;
                    }
                    
                }



            }
        }

       




            public static void end()
            {
                Console.Clear();
            }
       
        }
    }


