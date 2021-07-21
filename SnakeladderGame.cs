using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class SnakeladderGame
    {
        public int pos = 0;
        public void game()
        {
            while(pos<100)
            {
                Console.WriteLine("current position =" + pos);
                Random ran = new Random();
                int dice = ran.Next(1, 7);
                Console.WriteLine("player got : " + dice);
                int choice = ran.Next(0, 3);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("you got ladder");
                        pos = pos + dice;
                        Console.WriteLine("position after dice =" + pos);
                        break;
                    case 1:
                        Console.WriteLine("you got snake");
                        pos = pos - dice;
                        if (pos < 0)
                            pos = 0;
                        Console.WriteLine("position after dice =" + pos);
                        break;
                    default:
                        Console.WriteLine("you got nothing ");
                        Console.WriteLine("position after dice =" + pos);
                        break;
                }
            } 
        }
        
        
    }
}
