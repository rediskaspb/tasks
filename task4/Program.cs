// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c=Convert.ToInt32(Console.ReadLine());
// int max=Math.Max(a, Math.Max(b,c));            это работает
// Console.WriteLine(max);                        это работает     
//прогуглила про Math.Max

int max=a;
if (b>a)
{
    max=b;
}
else 
{
    max=a;
}
if (c>max)
{
    max=c;
    Console.WriteLine(max);
}
else
{
    Console.WriteLine(max);
}