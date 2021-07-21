using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadder
    {
        int position = 0;
        int dieCount = 0;

        public void PlayerPosition()
        {
            while (true)
            {
                Random random = new Random();
                int die = random.Next(1, 7);
                dieCount += 1; //Counting How Many Times Dice Was Played
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 1:
                        position += die;
                        break;
                    case 2:
                        position -= die;
                        if (position < 0)
                            position = 0;
                        break;
                    default:
                        position = position;
                        break;
                }
                if (position > 100) //If Player Goes Above 100
                    position -= die; //He Will Get Back To Previous Position
                else if (position == 100)
                    break;
                Console.WriteLine("Position of Player : " + position);
            }
            Console.WriteLine("Player Reached Winning Position : " + position);
            Console.WriteLine("Count Of Dice Played to Win the Game is : " + dieCount);
        }
    }
}
