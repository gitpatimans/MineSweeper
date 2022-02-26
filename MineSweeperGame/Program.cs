using MineSweeperGame.Mapper;
using MineSweeperGame.Service;
using System;

namespace MineSweeperGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] inputArray = {{ '*', '.', '.', '.' },
                                  { '.', '.', '*', '.' },
                                  { '.', '.', '.', '.' }};
            int rows = inputArray.GetLength(0);
            int cols = inputArray.GetLength(1);

            MineSweeperHelper mineSweeperHelper = new MineSweeperHelper(new MineSweeperMapper(rows, cols), inputArray);
            mineSweeperHelper.SolveMineSweeper();
            Console.ReadLine();
        }
    }
}
