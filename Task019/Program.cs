// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, 
// является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести 
// Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False

bool Palindrome (int num)
{
    if (num > 9999 && num <= 99999)
    {
        int  digit1 = num/10000;
        int  digit2 = (num/1000)%10;
        int  digit4 = (num/10)%10;
        int  digit5 = num%10;

        return digit1 == digit5 && digit2 == digit4;
    }
    else
    {
        Console.WriteLine ("Число не пятизначное");
        return false;
    }
}


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

bool result = Palindrome (number);
Console.WriteLine($"{result}");