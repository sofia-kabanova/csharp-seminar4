// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов
// и выводит их на экран.
//  Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Введите  длинну массива:");
//  если запрашиваем длинну массива у пользователя
int length = Convert.ToInt32(Console.ReadLine());
// int length = 8; // вводим длинну массива = 8 элементов
Console.WriteLine("Введите диапазон чисел массива:");
Console.Write("Min: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Max: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [length]; //создали массив из length элементов
// int по умолчанию инициализируется нулем, поэтому данный массив
// состоит из восьми нулей: [0,0,0,0,0,0,0,0]

void FillArray(int[] array, int min, int max)// делаем метод, который заполняет массив
{
    Random rnd = new Random();
    for (int i = 0; i<length; i++)
    {
        // arr[i] = new Random().Next(0, 10); 
        //записываем в индекс i случайное значение от 0 до 10
        arr[i] = rnd.Next(min,max); 
        //записываем в индекс i случайное число
    }
}
void PrintNumbers(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
       if(i<array.Length - 1) Console.Write($"{array[i]}, ");
       else Console.Write($"{array[i]} ");
    }
}

void PrintArray(int[] array) 
{
     Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
       if(i<array.Length - 1) Console.Write($"{array[i]}, ");
       else Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
Console.WriteLine($"Массив из {length} чисел: ");
FillArray(arr, minNumber, maxNumber);
PrintNumbers(arr);
Console.Write($" - > ");
PrintArray(arr);

