using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {

        static void Main(string[] args)
        {  //Entery point
            Game game = new Game();
            game.Play();
            Console.Read();
        }
    }
}
