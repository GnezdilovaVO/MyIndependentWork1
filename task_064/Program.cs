
int[,] arr = new int[10, 10];

arr[0, 0] = 1; arr[1, 0] = 1; arr[1, 1] = 1;

for (int i = 2; i < arr.GetLength(0); i++)          // row
{
    for (int j = 0; j < arr.GetLength(1); j++)      // col
    {
        if (j == 0) { arr[i, j] = 1; }
        else { arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j]; }
    }
}

for (int m = 0; m < arr.GetLength(0); m++)
{
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        if (arr[m, n] != 0) Console.Write($"{arr[m, n]} ");
    }
    Console.WriteLine();
}


//-----------------------------------------------------------------
int center = arr.GetLength(0) / 2;

for (int m = 0; m < arr.GetLength(0); m++)
{
    for (int n = 0; n < arr.GetLength(1); n++)
    {
        //if (arr[m, n] != 0) Console.Write($"{arr[m, n]} ");

        //arr[m, n] = 


    }
    Console.WriteLine();
}