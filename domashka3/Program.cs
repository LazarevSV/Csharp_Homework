//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 //через цикл находим 1ю, через остаток последнюю, и сравниваем, и зациклить это с отсеканием 1 и последней

/*

bool Palindrom(int n)
{
    int x = 0, y = n;
    while (n>0)
    {
        x = x * 10 + n % 10;
        n = n / 10;
    }
    return x == y;
}

    int n;
    Console.Write("input number: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (Palindrom(n))
    Console.WriteLine("Палиндром");
    else   
    Console.WriteLine("Не палиндром");

*/




//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Method1(int x1, int x2, int z1, int y1, int y2, int z2)
{
return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
}
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Method1(x1, x2, y1, y2, z1, z2));



*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Method1(int number)
{
int n = 1;
while(n <= number)
{
    Console.Write(Math.Pow(n, 3) + " ");
    n++;
}
}

Console.Write("Input number: ");
int x = Convert.ToInt32(Console.ReadLine());
Method1(x);
*/


