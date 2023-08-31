int[,,] array = CreateThreeDimensionalArray(2, 2, 2);

PrintThreeDimensionalArray(array);

static int[,,] CreateThreeDimensionalArray(int x, int y, int z)
{
    int[,,] newArray = new int[x, y, z];
    int value = 10;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                newArray[i, j, k] = value;
                value++;
            }
        }
    }

    return newArray;
}

static void PrintThreeDimensionalArray(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
        }
        Console.WriteLine();
    }
}