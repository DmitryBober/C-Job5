// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] randomArray (int length)
{
    int [] array = new int [length];
    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void showArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write(" -> ");
}

int [] array = randomArray(8);
showArray(array);
Console.WriteLine($"{array.Max() - array.Min()}");