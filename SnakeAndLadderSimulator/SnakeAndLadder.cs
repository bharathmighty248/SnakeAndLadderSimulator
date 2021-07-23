using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadder
    {
        //Variables
        int position1 = 0;
        int position2 = 0;

        //Constants
        const int LADDER = 1;
        const int SNAKE = 2;
        const int NOPLAY = 0;
        const int MAXPOSITION = 100;
        const int MINPOSITION = 0;

        Random random = new Random();
        /// <summary>
        /// Rolldie() Method is Defined To Use, Whenever Needs to Roll The Dice
        /// </summary>
        public int Rolldie()
        {
            int die = random.Next(1, 7);
            return die;
        }

        /// <summary>
        /// Player1 Method is Defined, to Give Chance to player 1 When gets his Turn.. 
        /// </summary>
        public int Player1()
        {
            int option = random.Next(0, 3);
            int dice = Rolldie();
            switch (option)
            {
                case LADDER:
                    position1 += dice;
                    int extraDice1 = Rolldie();  //When Player climbed Ladder, He will get Extra Chance
                    position1 += extraDice1;
                    break;
                case SNAKE:
                    position1 -= dice;
                    if (position1 < MINPOSITION)
                        position1 = MINPOSITION; //When Player Bite by Snake and If he Lost his Position Below Zero, He will Restart the Game From 0
                    break;
                case NOPLAY:
                    position1 += 0;  //If Noplay, He Doesn't Move Forward or Backward 
                    break;
            }
            if (position1 > MAXPOSITION)
                position1 -= dice;      //If Player Moves Above MaxPosition 100, He will Return Back to Previous Position 
            return position1;   
        }

        /// <summary>
        /// Player2 Method is Defined, to Give Chance to player 2 When gets his Turn.. 
        /// </summary>
        public int Player2()
        {
            int option = random.Next(0, 3);
            int dice = Rolldie();
            switch (option)
            {
                case LADDER:
                    position2 += dice;
                    int extraDice2 = Rolldie();   //When Player climbed Ladder, He will get Extra Chance
                    position2 += extraDice2;
                    break;
                case SNAKE:
                    position2 -= dice;
                    if (position2 < MINPOSITION)    //When Player Bite by Snake and If he Lost his Position Below Zero, He will Restart the Game From 0    
                        position2 = MINPOSITION;
                    break;
                case NOPLAY:
                    position2 += 0;    //If Noplay, He Doesn't Move Forward or Backward
                    break;
            }
            if (position2 > MAXPOSITION)
                position2 -= dice;   //If Player Moves Above MaxPosition 100, He will Return Back to Previous Position
            return position2;
        }
    }
}
