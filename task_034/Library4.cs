public static class Library4
{
    public static void NegativeElementArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * -1;
        }
    }
}