namespace MineSweeperGame.Service
{
    internal interface IMineSweeper
    {
        void CalculateForUpperCell(int currentRow, int currentCol);

        void CalculateForBelowCell(int currentRow, int currentCol);

        void CalculateForLeftCell(int currentRow, int currentCol);

        void CalculateForRightCell(int currentRow, int currentCol);

        void CalculateForUpperLeftCell(int currentRow, int currentCol);

        void CalculateForUpperRightCell(int currentRow, int currentCol);

        void CalculateForBelowLeftCell(int currentRow, int currentCol);

        void CalculateForBelowRightCell(int currentRow, int currentCol);
    }
}
