//Тимохин Сергей (Задача №2 Заполнить массив числами рандомом от -100 до 100)
public static class Library_2
{
    public static void FeelArray(int[] Random)
    {
        for (int i = 0, i< Random.length; i++)
        {
            Random[i] = new Random().Next(-100, 100);
        }
    }
}
