// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N


void WriteTableCube(int number)
{
    int i = 1;
    while(i <= number)
    {
        Console.WriteLine($"{i, 3} -> {i*i*i, 5}"); 
        i++;
    }
}


Console.Write("Введите число: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
WriteTableCube(n);