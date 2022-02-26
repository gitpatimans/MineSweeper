namespace MineSweeperGame.Mapper
{
    internal interface IMineSweeperMapper
    {
        int[,] ConvertInputCharArrayToIntArray(char[,] charArray);

        char[,] ConvertInputIntArrayToCharArray(int[,] intArray);
    }
}
