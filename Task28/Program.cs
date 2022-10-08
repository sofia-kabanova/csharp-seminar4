// Напишите программу, которая 
// принимает на вход число N - пользовательский ввод
// выдает произведение чисел от 1 до N, т.е. находит факториал числа N
// Например:
// 4->24
// 5->120
// в решении нет проверки для 0 или отриц. числа
// на вводе необходимо добавить проверку на положительное число
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int FctrlNumbers(int num)// вводим метод для вычисления факториала
{
    int fctrl = 1;
    for (int i = 1; i <= num; i++)
    {
        fctrl *= i;//fctrl = fctrl*i; 
    }
    return fctrl;
}
int fctrlNumbers = FctrlNumbers(number); 
// переменная, куда записываем возвращенное методом значание
Console.WriteLine($"Произведение чисел от 1 до {number} (факториал {number})= {fctrlNumbers}");