/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number2 = 0;
while (number2 <= number) {
    number2 += 2;
    if (number2 > number) {
        return;
    }
    Console.WriteLine(number2);
}