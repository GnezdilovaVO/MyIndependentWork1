public static class Library
{
    public static int GetCount(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int[,] GetPaskal(int[,] arr)
    {
        arr[0, 0] = 1; arr[1, 0] = 1; arr[1, 1] = 1;

        for (int i = 2; i < arr.GetLength(0); i++)          // row
        {
            for (int j = 0; j < arr.GetLength(1); j++)      // col
            {
                if (j == 0) arr[i, j] = 1;
                else arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
            }
        }
        return arr;
    }
    public static void PrintArray(int[,] arr)
    {
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                if (arr[m, n] != 0) Console.Write($"{arr[m, n]}  ");
            }
            Console.WriteLine();
        }
    }
    public static int[,] GetPaskalCenter(int[,] arr)
    {   
        int lengthArr = arr.GetLength(1);
        arr[0, lengthArr/2] = 1; arr[1, lengthArr/2-1] = 1; arr[1, lengthArr/2+1] = 1;
        for (int i = 2; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == 0) arr[i, j] = arr[i-1, j+1];
                else if (j == arr.GetLength(1)-1) arr[i, j] = arr[i-1, j-1];
                else arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j+1];
            }
        }
        return arr;
    }
    public static void PrintArrayCenter(int[,] arr)
    {
        for (int m = 0; m < arr.GetLength(0); m++)
        {
            for (int n = 0; n < arr.GetLength(1); n++)
            {
                if (arr[m, n] != 0) Console.Write($" {arr[m, n]} ");
                else Console.Write("   ");
            }
            Console.WriteLine();
        }
    }
}