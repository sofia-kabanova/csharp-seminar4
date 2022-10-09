// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов
// и выводит их на экран.
//  Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// Console.WriteLine("Введите  длинну массива:");
//  если запрашиваем длинну массива у пользователя
// int length = Convert.ToInt32(Console.ReadLine());
int length = 8; // вводим длинну массива = 8 элементов
int[] arr = new int [length]; //создали массив из length элементов
// int по умолчанию инициализируется нулем, поэтому данный массив
// состоит из восьми нулей: [0,0,0,0,0,0,0,0]

void FillArray(int[] array)// делаем метод, который заполняет массив
{
    for (int i = 0; i<length; i++)
    {
        // arr[i] = new Random().Next(0, 10); 
        //записываем в индекс i случайное значение от 0 до 10
        arr[i] = new Random().Next(); 
        //записываем в индекс i случайное число
    }
}
void PrintNumbers(int[] array) 
{
    for (int i = 0; i+1 < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }   
}
void PrintNumbersLast(int[] array) 
{
        Console.Write(arr[^1]);
}
void PrintArray(int[] array) 
{
    for (int i = 0; i+1 < length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }   
}
Console.WriteLine($"Массив из {length} чисел: ");
FillArray(arr);
PrintNumbers(arr);
PrintNumbersLast(arr);
Console.Write($" - > [ ");
PrintArray(arr);
PrintNumbersLast(arr);
Console.Write($" ]");

