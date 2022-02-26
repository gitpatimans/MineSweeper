using MineSweeperGame.Models;
using System;

namespace MineSweeperGame.Mapper
{
    internal class MineSweeperMapper : IMineSweeperMapper
    {
        private int _maxRows;
        private int _maxCols;

        public MineSweeperMapper(int rows, int cols)
        {
            this._maxRows = rows;
            this._maxCols = cols;
        }

        public int[,] ConvertInputCharArrayToIntArray(char[,] charArray)
        {
            int[,] processedOutputIntArray = new int[_maxRows, _maxCols];

            for (int currentRow=0; currentRow < _maxRows; currentRow++)
            {
                for (int currentCol = 0; currentCol < _maxCols; currentCol++)
                {
                    switch(charArray[currentRow, currentCol])
                    {
                        case MineSweeperConstants.Mine:
                            processedOutputIntArray[currentRow, currentCol] = MineSweeperConstants.MineDigit;
                            break;
                        case MineSweeperConstants.DotChar:
                            processedOutputIntArray[currentRow, currentCol] = MineSweeperConstants.Zero;
                            break;
                    }
                }
            }
            return processedOutputIntArray;
        }

        public char[,] ConvertInputIntArrayToCharArray(int[,] intArray)
        {
            char[,] processedOutputCharArray = new char[_maxRows, _maxCols];
            for (int currentRow = 0; currentRow < _maxRows; currentRow++)
            {
                for (int currentCol = 0; currentCol < _maxCols; currentCol++)
                {
                    switch (intArray[currentRow, currentCol])
                    {
                        case MineSweeperConstants.MineDigit:
                            processedOutputCharArray[currentRow, currentCol] = MineSweeperConstants.Mine;
                            break;
                        default:
                            processedOutputCharArray[currentRow, currentCol] = Convert.ToChar(intArray[currentRow, currentCol].ToString());
                            break;
                    }
                }
            }
            return processedOutputCharArray;
        }
    }
}
