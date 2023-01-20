// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] randomArray (int length)
{
    int [] array = new int [length];
    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int even(int[] array) 
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
        if (array[i]%2 == 0)
            count++;
    return count;
}

void showArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write(" -> ");
}
int [] array = randomArray(11);
showArray(array);
Console.WriteLine(even(array));