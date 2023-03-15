public static class Library3
{
    public static int[,] GetResult(int[,] a, int[,] b)
    {
        int[,] c = new int [3,3];
        
        int temp = 0;

        for (int i = 0; i < a.GetLength(0); i++)        // row
        {
            for (int j = 0; j < a.GetLength(1); j++)    // col
            {
                for (int m = 0; m < a.GetLength(1); m++)
                {
                    temp = temp + a[i, m] * b[j, m];
                }
                c[i, j] = temp;
                temp = 0;
            }
        }
        return c;
    }

}