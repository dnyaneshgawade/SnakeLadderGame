using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class SnakeladderGame
    {
        int pos = 0;
        public void game()
        {
            Console.WriteLine("current position =" + pos);
            Random ran = new Random();
            int dice = ran.Next(1, 7);
            Console.WriteLine("player got : "+dice);
        }
        
    }
}
