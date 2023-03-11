public static class Library 
{
    public static string PrintArray(int[] array)
    {
        string elArray = String.Empty;
        for(int i = 0; i < array.Length; i++)
        {
            elArray = elArray + array[i] + " ";
        }
        return elArray;
    }
}