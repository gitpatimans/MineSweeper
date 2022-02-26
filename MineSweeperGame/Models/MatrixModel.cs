namespace MineSweeperGame.Models
{
    internal class MatrixModel
    {
        private int _maxRows;
        private int _maxCols;
        public int[,] inputArray;

        public int MaxRows
        {
            get { return _maxRows; }
            set { _maxRows = value; }
        }

        public int MaxCols
        {
            get { return _maxCols; }
            set { _maxCols = value; }
        }

        public MatrixModel(int[,] inputArray)
        {
            this._maxRows = inputArray.GetLength(0);
            this._maxCols = inputArray.GetLength(1);
            this.inputArray = inputArray;
        }
    }
}
