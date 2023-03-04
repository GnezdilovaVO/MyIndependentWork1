Console.WriteLine("Подсчитать сумму цифр в числе");

static int GetNumber(string s)
{
    Console.Write(s);
    return Convert.ToInt32(Console.ReadLine());
}

static int GetSum(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}


int num = GetNumber("Введите число: ");
int sum = GetSum(num);

Console.WriteLine("Сумма числе в числе: " + sum);





