using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int playerScore = 0;
        int enemyScore = 0 ;

        Console.WriteLine("\nWelcome to rock paper scissor game !");

        while(playerScore != 3 && enemyScore != 3)
        {
            Console.WriteLine("\nPlayer score - " + playerScore + ". Enemy score - " + enemyScore);
            Console.WriteLine("\nEnter 'r' for rock | 'p' for paper | 's' for scissor ");
            string playerChoice = Console.ReadLine();

            if (playerChoice != "r" && playerChoice != "p" & playerChoice != "s")
            {
                Console.WriteLine("\nPlease enter the valid Key !");
                continue;
            }

            int enemyChoice = random.Next(0,3);

            string finalChoice = playerChoice == "r" ? "Rock" : playerChoice == "p" ? "Paper" : "Scissor";
            Console.WriteLine($"You choose - {finalChoice}");

            if(enemyChoice == 0)
            {
                Console.WriteLine("\nEnemy chooses - Rock.");
               
                switch (playerChoice)
                {
                    case "r": Console.WriteLine("\nTie!");
                        break;

                    case "p": Console.WriteLine("\nPlayer Wins this round!");
                        playerScore ++;
                        break;

                    case "s" : Console.WriteLine("\nEnemy Wins this round !");
                        enemyScore++;
                        break;
                }
            }
            else if(enemyChoice==1)
            {
                Console.WriteLine("\nEnemy chooses - Paper.");

                switch (playerChoice)
                {
                    case "r" : Console.WriteLine("\nEnemy Wins this round !");
                        enemyScore++;
                        break;

                    case "p" : Console.WriteLine("\nTie");
                        break;

                    case "s" :  Console.WriteLine("\nPlayer Wins this round !");
                        playerScore ++;
                        break;
                }
            }
            else{
                Console.WriteLine("\nEnemy chooses - Scissor.");

                switch(playerChoice)
                {
                    case "r" : Console.WriteLine("\nPlayer Wins this round !");
                        playerScore ++;
                        break;

                    case "p" : Console.WriteLine("\nEnemy Wins this round !");
                        enemyScore ++;
                        break;

                    case "s" : Console.WriteLine("\nTie!");
                        break;
                }
            }
        }

        if (playerScore == 3)
        {
            Console.WriteLine("\nYou win the game !");
        }
        else{
            Console.WriteLine("\nEnemy Win the game !");
        }
    }
}