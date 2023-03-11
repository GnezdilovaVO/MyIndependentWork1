public static class Library1
{
public static void  FillArray(int[] example)
{
    for (int index = 0; index < example.Length; index++) 
    {
        example[index] = new Random().Next(1,10);
    }
}

}