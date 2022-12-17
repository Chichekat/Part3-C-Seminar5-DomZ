//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = GetPrintArray(4, 100, 1000);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    count++;
}
Console.WriteLine($"В массиве {count} четных числа");


int [] GetPrintArray (int size, int minValue, int maxValue){
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine($"[{String.Join(", ", result)}]");
    return result;
}
