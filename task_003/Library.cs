public static class Library
{

    public static int GetNumber(string s)
    {
        Console.Write(s);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int GetSum(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }

        return sum;
    }

}