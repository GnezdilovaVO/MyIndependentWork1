﻿using static Library;
using static Library3;
using static Library2;
int[,] arrayA = new int[3, 3];
int[,] arrayB = new int[3, 3];
metod1(arrayA);
metod1(arrayB);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
int [,]  multiArray = GetResult(arrayA, arrayB);
PrintArray(multiArray);
