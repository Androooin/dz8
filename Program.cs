//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8





Console.WriteLine("Напишите любое целое число ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (num % 2 == 0)
{
    while (index <= num)
    {
        Console.Write(index + " ");
        index = index + 2;
    }
}
else
{
    while (index <= num - 1)
    {

        Console.Write(index + " ");
        index = index + 2;
    }
}

