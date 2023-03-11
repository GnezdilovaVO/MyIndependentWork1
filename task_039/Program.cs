using static Library;
using static Library1;
using static Library3;

int[] array = new int[10];
int[] newArray = new int[5];
FillArray(array);
Console.WriteLine(PrintArray(array));
newArray = GetResult(array);
Console.WriteLine(PrintArray(newArray));

