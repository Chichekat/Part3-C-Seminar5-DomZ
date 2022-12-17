//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int[] arr = GetPrintArray(4, -10, 100);
Console.WriteLine($"Сумма элементов на нечетных позициях = {SumElements(arr)}");

int [] GetPrintArray (int size, int minValue, int maxValue){
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine($"[{String.Join(", ", result)}]");
    return result;
}


int SumElements (int[] array){
    int sum = 0;
        for (int i = 0; i < array.Length; i++)
            {   
                if (i % 2 == 1)
                sum = sum + array[i];
            }
        return sum;
}
