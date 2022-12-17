//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива. [3 7 22 2 78] -> 76

double[] arr = GetPrintArray(4);
Console.WriteLine($"Минимальный элемент = {MinElement(arr)}");
Console.WriteLine($"Максимальный элемент = {MaxElement(arr)}");
double raznMinMax = MaxElement(arr) - MinElement(arr);
Console.WriteLine($"Разница = {raznMinMax}");

double[] GetPrintArray (double size){
    double[] result = new double [4];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*100;
    }
    Console.WriteLine($"[{String.Join(", ", result)}]");
    return result;
}

double MinElement (double[] array){
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double MaxElement (double[] array){
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}