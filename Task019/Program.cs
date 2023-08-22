// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

bool Palindrome (int num)
{
    int  digit1 = num/10000;
    int  digit2 = (num/1000)%10;
    int  digit4 = (num/10)%10;
    int  digit5 = num%10;

    return digit1 == digit5 && digit2 == digit4;
}


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number > 9999 && number <= 99999)
{
    bool result = Palindrome (number);
    Console.WriteLine (result ? "Да" : "Нет");
}
else
{
    Console.Write ("Неверное число!");
}