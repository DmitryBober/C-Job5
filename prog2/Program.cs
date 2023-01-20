 //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

 int[] randomArray (int length)
 {
    int [] array = new int [length];
    for (int i=0; i < array.Length; i++){
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int sum(int[] array) 
{
    int sum = 0;
    for (int i=1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

void showArray (int[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.Write(" -> ");
}
int [] array = randomArray(4);
showArray(array);
Console.WriteLine(sum(array));