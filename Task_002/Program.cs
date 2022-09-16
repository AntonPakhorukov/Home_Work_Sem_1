/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int thridNumber = int.Parse(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max) {
    max = secondNumber;
}  
if (thridNumber > max) {
    max = thridNumber;
}
Console.WriteLine(max);