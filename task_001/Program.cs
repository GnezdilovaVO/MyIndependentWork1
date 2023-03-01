int GetNumber(string s)
{
    Console.Write(s);

    return Convert.ToInt32(Console.ReadLine());
}

int GetResult(int num)
{
    int i = num % 10;       //      125 % 10 = 5  
    num = num / 100;        //      125 / 100 = 1
    num = num * 10 + i;     //      1 * 10 + 5 =  15

    return num;
}




int N = GetNumber("Введите число: ");

int result = GetResult(N);

Console.WriteLine(result);