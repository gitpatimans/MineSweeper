using MineSweeperGame.Models;

namespace MineSweeperGame.Service
{
    internal class MineSweeper : IMineSweeper
    {
        private MatrixModel matrixModel;

        public MineSweeper(MatrixModel matrixModel)
        {
            this.matrixModel = matrixModel;
        }

        #region Private Methods
        private int GetUpLeftIndex(int index)
        {
            return --index;
        }

        private int GetBelowRightIndex(int index)
        {
            return ++index;
        }
        #endregion

        public void CalculateForBelowCell(int currentRow, int currentCol)
        {
            int belowRowIndex = currentRow < (this.matrixModel.MaxRows - 1) ? GetBelowRightIndex(currentRow) : -1;
            if(belowRowIndex != -1)
            {
                if (this.matrixModel.inputArray[belowRowIndex, currentCol] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForBelowLeftCell(int currentRow, int currentCol)
        {
            int belowRowIndex = currentRow < (this.matrixModel.MaxRows - 1) ? GetBelowRightIndex(currentRow) : -1;
            int leftColIndex = currentCol > 0 ? GetUpLeftIndex(currentCol) : -1;
            if (belowRowIndex != -1 && leftColIndex != -1)
            {
                if (this.matrixModel.inputArray[belowRowIndex, leftColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForBelowRightCell(int currentRow, int currentCol)
        {
            int belowRowIndex = currentRow < (this.matrixModel.MaxRows - 1) ? GetBelowRightIndex(currentRow) : -1;
            int rightColIndex = currentCol < (this.matrixModel.MaxCols - 1) ? GetBelowRightIndex(currentCol) : -1;
            if (belowRowIndex != -1 && rightColIndex != -1)
            {
                if (this.matrixModel.inputArray[belowRowIndex, rightColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForLeftCell(int currentRow, int currentCol)
        {
            int leftColIndex = currentCol > 0 ? GetUpLeftIndex(currentCol) : -1;
            if(leftColIndex != -1)
            {
                if (this.matrixModel.inputArray[currentRow, leftColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForRightCell(int currentRow, int currentCol)
        {
            int rightColIndex = currentCol < (this.matrixModel.MaxCols - 1) ? GetBelowRightIndex(currentCol) : -1;
            if(rightColIndex != -1)
            {
                if (this.matrixModel.inputArray[currentRow, rightColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForUpperCell(int currentRow, int currentCol)
        {
            int upRowIndex = currentRow > 0 ? GetUpLeftIndex(currentRow) : -1;
            if(upRowIndex != -1)
            {
                if(this.matrixModel.inputArray[upRowIndex, currentCol] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForUpperLeftCell(int currentRow, int currentCol)
        {
            int upRowIndex = currentRow > 0 ? GetUpLeftIndex(currentRow) : -1;
            int leftColIndex = currentCol > 0 ? GetUpLeftIndex(currentCol) : -1;
            if(upRowIndex != -1 && leftColIndex != -1)
            {
                if (this.matrixModel.inputArray[upRowIndex, leftColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }

        public void CalculateForUpperRightCell(int currentRow, int currentCol)
        {
            int upRowIndex = currentRow > 0 ? GetUpLeftIndex(currentRow) : -1;
            int rightColIndex = currentCol < (this.matrixModel.MaxCols - 1) ? GetBelowRightIndex(currentCol) : -1;
            if (upRowIndex != -1 && rightColIndex != -1)
            {
                if (this.matrixModel.inputArray[upRowIndex, rightColIndex] == MineSweeperConstants.MineDigit)
                {
                    this.matrixModel.inputArray[currentRow, currentCol] += 1;
                }
            }
        }
    }
}
