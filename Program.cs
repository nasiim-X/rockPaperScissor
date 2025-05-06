using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int playerScore = 0;
        int enemyScore = 0 ;

        Console.WriteLine("Welcome to rock paper scissor game !");

        while(playerScore != 3 && enemyScore != 3)
        {
            Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
            Console.WriteLine("Enter 'r' for rock | 'p' for paper | 's' for scissor ");
            string playerChoice = Console.ReadLine();

            int enemyChoice = random.Next(0,3);

            Console.WriteLine("You choose - " + playerChoice);

            if(enemyChoice == 0)
            {
                Console.WriteLine("Enemy chooses - Rock.");
               
                switch (playerChoice)
                {
                    case "r": Console.WriteLine("Tie!");
                        break;

                    case "p": Console.WriteLine("Player Wins this round!");
                        playerScore ++;
                        break;

                    default : Console.WriteLine("Enemy Wins this round !");
                        enemyScore++;
                        break;
                }
            }
            else if(enemyChoice==1)
            {
                Console.WriteLine("Enemy chooses Paper.");

                switch (playerChoice)
                {
                    case "r" : Console.WriteLine("Enemy Wins this round !");
                        enemyScore++;
                        break;

                    case "p" : Console.WriteLine("Tie");
                        break;

                    default : Console.WriteLine("Player Wins this round !");
                        playerScore ++;
                        break;
                }
            }
            else{
                Console.WriteLine("Enemy chooses Scissor.");

                switch(playerChoice)
                {
                    case "r" : Console.WriteLine("Player Wins this round !");
                        playerScore ++;
                        break;

                    case "p" : Console.WriteLine("Enemy Wins this round !");
                        enemyScore ++;
                        break;

                    default : Console.WriteLine("Tie!");
                        break;
                }
            }
        }

        if (playerScore == 3)
        {
            Console.WriteLine("You win the game !");
        }
        else{
            Console.WriteLine("Enemy Win the game !");
        }
    }
}