public static class Library1
{
    public static string printArray(int[] collection)
    {
        string massiv = String.Empty;
        for(int i = 0; i < collection.Length; i++)
        {
            if (i == collection.Length-1)
            {
            massiv = massiv + collection[i];
            }
            else 
            {massiv = massiv + collection[i] + ", ";}
        }
        return massiv;
    }
}
    