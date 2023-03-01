Console.WriteLine(" По двум заданным числам проверять является ли одно квадратом другого");

bool SQ(int A, int B)
{
    if (A / B == B)
    {
        return true; //Console.WriteLine("Является");
    }
    else
    {
        return false; //Console.WriteLine("Не является");
    }
}


string GetResult(bool b)
{
    if (b) {return "Является";} else {return "Не является";}
}

int A = 49;
int B = 7;

bool check = SQ(A, B);
string result = GetResult(check);

Console.WriteLine(result);