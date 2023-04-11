// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecNum(int number)
{
    
    int result = ((number / 10) % 10);
    return result;
}
Console.WriteLine("Введи трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number <= 99 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(SecNum(number));
}


*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

/*

bool RabWux(int a)
{
    if (a == 7 || a == 6) return true;
    else return false;
}

Console.Write("Введи день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day >7)
    {
    Console.WriteLine("Вы ввели число не в интревале от 0 до 7. В неделе 7 дней!");
    }
else    

if (RabWux(day))
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий день");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int NumThird(int num)
{
while (num > 1000)
    {
    num = num / 10;
    }
num = num % 10;
return num;
}
Console.Write("Введи число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра этого числа: " + NumThird(num2));
}