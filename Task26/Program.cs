// Напишите программу, которая 
// принимает на вход число - пользовательский ввод
// выдает количество цифр в числе
// Например:
// 456->3
// 78->2
// 89126->5

// данное решение не работает для нуля и отрицательного числа. 
// нужно сделать доп. условия для нуля и отриц. числа
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Count(int num)
{
    int i; // или int i = default для читаемости кода
    for (i = 0; num>0; i++)
    {
       num /= 10; //  деление на 10
    }
    return i;
}
int result = Count(number);
Console.WriteLine(result);

