using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to snake ladder game!");
            SnakeladderGame s = new SnakeladderGame();
            s.game();
        }
    }
}
