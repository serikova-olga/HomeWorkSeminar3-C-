/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.Write("input five digit number: ");
int n = Convert.ToInt32(Console.ReadLine()) ;

if (n > 99999 || n < 1000)
{
    Console.WriteLine("input five digit number: ");
    return;
}

int digit1 = n / 10000;
int digit2 = n / 1000 %10;
int digit5 = n % 10;
int digit4 = n /10 % 10;

if (digit1==digit5 && digit2==digit4)
{
    Console.WriteLine ("yes");
}

else
{
    Console.WriteLine ("No");
}