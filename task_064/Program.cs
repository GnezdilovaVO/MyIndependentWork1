using static Library;
int count = GetCount("Введите количество: ");
//int[,] array = new int[count, count];
int[,] arrayCenter = new int[count, count*2-1];
// array = GetPaskal(array);
// PrintArray(array);
arrayCenter = GetPaskalCenter(arrayCenter);
Console.WriteLine();
PrintArrayCenter(arrayCenter);