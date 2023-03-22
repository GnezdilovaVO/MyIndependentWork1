public static class Library
{
    public static double GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static string GetElements(int start, int number)
    {
        if (start < number) return GetElements(start+1, number) + start + " ";
        else return $"{number} ";
        // string collection = string.Empty;
        // for (int i = 1; i <= number; i++)
        // {
        //     collection = collection + i + " ";
        // }
        // return collection;
    }
    public static int GetSum(int n, int m)
    {
        if (n <= m) return n + GetSum(n+1, m);
        else return 0;
    }
    public static int GetSumNumber(int number)
    {
        if (number == 0) return 0;
        else return number%10 + GetSumNumber(number/10);
    }
    public static double FunctionAkkerman (double n, double m)
    {
        if (n == 0) return m+1;
        else if (m ==0) return FunctionAkkerman(n-1, 1);
        else return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
    }
} 