using System;

namespace SnakeAndLadderSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Position = 0;
            int player2Position = 0;

            SnakeAndLadder Game = new SnakeAndLadder();
         
            while (player1Position != 100 && player2Position != 100)   //While Loop Until AnyOne Player Reaches 100
            {
                for (int chance=1; chance <= 2; chance++)    // This For Loop Gives the Chance To Each Player One By One
                {
                    if (chance == 1)      //Player1 Gets his Turn
                    {
                        player1Position = Game.Player1();   // Player1 Will Use his Turn
                    }
                    else if (chance == 2)   //Player2 Gets his Turn
                    {
                        player2Position = Game.Player2();    // Player2 Will Use his Turn
                    }
                }  
            }
            Console.WriteLine("Player 1 Position: " + player1Position);
            Console.WriteLine("Player 2 Position: " + player2Position);
            // RePorts, Who Won the Game
            if (player1Position > player2Position)
                Console.WriteLine("**Player 1 Won this Game**");
            if (player2Position > player1Position)
                Console.WriteLine("**Player 2 Won this Game**");
        }
    }
}
