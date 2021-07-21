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
            while (position <= 100)
            {
                Random random = new Random();
                int die = random.Next(1, 7);
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

            }
            Console.WriteLine("Position of Player : " + position);
        }
    }
}
