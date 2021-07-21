using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderSimulator
{
    class SnakeAndLadder
    {
        int position = 0;

        public void PlayerPosition()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            position = position + die;
            Console.WriteLine("Position of Player : " + position);
        }
    }
}
