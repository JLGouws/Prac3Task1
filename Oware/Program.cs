/* This is an almost-complete translation of https://github.com/haarismemon/oware/ from Java to C#
*/
using System;

namespace Oware
{
    class Program
    {
        static void Main(string[] args)
        {
            Player one = new Player("Player 1", new ScoreHouse());
            Player two = new Player("Player 2", new ScoreHouse());
            Board b = new Board(one, two);
            // rest left as exercise to reader!
        }
    }
}
