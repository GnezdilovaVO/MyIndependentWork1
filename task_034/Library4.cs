public static class Library4
{
    void NegativeElementArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * -1;
        }
    }
}