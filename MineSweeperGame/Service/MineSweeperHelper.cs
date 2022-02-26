using MineSweeperGame.Mapper;
using MineSweeperGame.Models;
using System;

namespace MineSweeperGame.Service
{
    internal class MineSweeperHelper : IMineSweeperHelper
    {
        private IMineSweeperMapper _mineSweeperMapper;
        private MatrixModel _matrixModel;
        private MineSweeper _mineSweeper;
        
        public MineSweeperHelper(IMineSweeperMapper mineSweeperMapper, char[,] inputArray)
        {
            this._mineSweeperMapper = mineSweeperMapper;

            // Process Input Array => Replace Char values with Digits
            this._matrixModel = new MatrixModel(ProcessInputArray(inputArray));

            this._mineSweeper = new MineSweeper(this._matrixModel);
        }

        public void SolveMineSweeper()
        {
            // Process Mine Sweeper Matrix
            SolveMineSwipperMatrix();

            // Print Processed Matrix into required Output format
            PrintOutPut();
        }

        private void SolveMineSwipperMatrix()
        {
            int[,] processedIntArray = this._matrixModel.inputArray;
            for (int currentRow = 0; currentRow < this._matrixModel.MaxRows; currentRow++)
            {
                for (int currentCol = 0; currentCol < this._matrixModel.MaxCols; currentCol++)
                {
                    // Process below only if current cell is NOT MineDigit (9)
                    if(processedIntArray[currentRow, currentCol] != MineSweeperConstants.MineDigit)
                    {
                        this._mineSweeper.CalculateForUpperCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForBelowCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForLeftCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForRightCell(currentRow, currentCol);

                        this._mineSweeper.CalculateForUpperLeftCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForUpperRightCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForBelowLeftCell(currentRow, currentCol);
                        this._mineSweeper.CalculateForBelowRightCell(currentRow, currentCol);
                    }
                }
            }
        }

        private void PrintOutPut()
        {
            char[,] outPutArray = this._mineSweeperMapper.ConvertInputIntArrayToCharArray(this._matrixModel.inputArray);
            for(int row = 0; row < this._matrixModel.MaxRows; row++)
            {
                for(int col = 0; col < this._matrixModel.MaxCols; col++)
                {
                    Console.Write(outPutArray[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private int[,] ProcessInputArray(char[,] inputArray)
        {
            return this._mineSweeperMapper.ConvertInputCharArrayToIntArray(inputArray);
        }
    }
}
