// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.


int number = new Random().Next(9999, 99999);
Console.WriteLine(number);

string str = number.ToString();
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число палиндром ");
}
else
{
    Console.WriteLine("Число не палиндром ");
}