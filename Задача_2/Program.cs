//Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число");
string input = Console.ReadLine();
int number1 = Convert.ToInt32(input);
Console.WriteLine("Введите второе число");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
if (number2 * number2 == number1 ) 
{
    Console.WriteLine("Да втрое число это квадрат первого");
}
else
{
    Console.WriteLine("Второе не является квадратом первого");
}