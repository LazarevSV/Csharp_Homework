//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)
/*
void VozvedVstepen(int a, int b)

{
int result = 1;
for(int i = 1; i <= b; i++)

{
    result *= a;
}
Console.WriteLine($"{a} в степени {b} = {result}");
}

Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

VozvedVstepen(numberA, numberB);

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе . 452 -> 11

/*
void SumNumbers(int n, int b)
{
    int sum = 0;
    for (int i = 1; i <= b; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}


int Numbers(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
Console.WriteLine("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int b = Numbers(number);
SumNumbers(number, b);
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


int[] CreateArray(int size) {
    int[] array = new int[size];

    for (int i = 0; i < size; i++) {
    Console.Write($"Input element of array index {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array) {
    int i = 0;
    Console.Write("[");
    while (i < array.Length) {
    Console.Write(array[i]);
    i++;
    if (i < array.Length) {
        Console.Write(", ");
    }
    }
    Console.WriteLine("]");
}

Console.Write("Input a size of array: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(sizeArray);
ShowArray(newArray);