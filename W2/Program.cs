/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число: "); 
 
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Первое число: " + a);
int b = int.Parse(Console.ReadLine()); 
Console.WriteLine("Второе число: " + b);
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Третье число: " + c);


 if (a>=b && a>=c)  {
    Console.WriteLine("max: " + a);
}
else if (b>=c)  {
    Console.WriteLine("max: " + b);
}
else {
    Console.WriteLine("max " + c);
}
