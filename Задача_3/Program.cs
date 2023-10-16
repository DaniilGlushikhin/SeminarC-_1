//Напишите программу, которая будет выдавать название дня недели
//по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Введите номер дня недели ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
    if( number == 1)   
    {
        Console.WriteLine("Понедельник");
    }
    if(number == 2)
    {
        Console.WriteLine("Вторник");
    }
    if(number == 3)
    {
        Console.WriteLine("Среда");
    }
    if(number == 4)
    {
        Console.WriteLine("Четверг");
    }
    if(number == 5)
    {
        Console.WriteLine("Пятница");
    }
    if(number == 6)
    {
        Console.WriteLine("Суббота");
    }
    if(number == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    if(number < 1)
    {
        Console.WriteLine("Нет такого дня недели");
    }
    if(number > 7)
    {
        Console.WriteLine("Нет такого дня недели");
    }

/*
Console.Write("Введите номер дня: ");
string input = Console.ReadLine();
int day = Convert.ToInt32(input);

switch (day)
{
case 1:
Console.WriteLine("понедельник");
break;

case 2:
Console.WriteLine("вторник");
break;

case 3:
Console.WriteLine("среда");
break;

case 4
Console.WriteLine("четверг");
break;

case 5:
Console.WriteLine("пятница");
break;

case 6:
Console.WriteLine("суббота");
break;

case 7:
Console.WriteLine("воскресенье");
break;

default:
Console.WriteLine("ошибка");
break;
}
*/