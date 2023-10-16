//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

// 1.Принимать число
// 2.Посчитать квадрат
// 3.Вывод числа

//int - string = 123 - "123"
//int
//Console.ReadLine => string - командой ридлайн переводит в строку
//string => int
//Convert.ToInt32(string) => int - команда конвертИнт32 переводит в число

Console.WriteLine ("Введите число"); // консоль.врайтлайн позволяет в консоли вводить число
string input = Console.ReadLine ();
int number = Convert.ToInt32(input);
int result = number * number;
Console.WriteLine(result);
