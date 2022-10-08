﻿// Задача 30. Напишите программу, которая
// выводит массив из 8 элементов 
//(или запрашиваем длинну массива у пользователя)
// и заполняет массив
// нулями и единицами в случайном порядке
//  [0,1,1,0,0,1,1,0]
//   0,1,2,3,4,5,6,7 - индексы переменных массива
// индекс последнего элемента = длинна -1
// запись элементов массива через цикл
// вывод элементов массива через цикл
Console.WriteLine("Введите  длинну массива:");
int length = Convert.ToInt32(Console.ReadLine());
//int length = 8;
int[] arr = new int [length]; //создали массив из 8 элементов
// int по умолчанию инициализируется нулем, поэтому данный массив
// состоит из восьми нулей: [0,0,0,0,0,0,0,0]

void FillArray(int[] array)// делаем метод, который заполняет массив
{
    for (int i = 0; i<length; i++)
    {
        arr[i] = new Random().Next(0,2); //записываем в индекс i случайное значение 
        // в диапазоне от 0 до 1
    }
    
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(arr[i]); //выводим печать итого (i) элемента
    }   
}
FillArray(arr);
PrintArray(arr);
