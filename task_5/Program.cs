//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4 8 -> 2, 4, 6, 8
Console.Write("введите число");
int numberN = int.Parse(Console.ReadLine());
int numberC = 1;

while (numberC <= numberN)
{ 
    Console.Write(numberC+" ");
numberC++;    
}