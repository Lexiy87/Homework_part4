// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetNumber(string message)
{
    int number = 0;
    System.Console.WriteLine(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else System.Console.WriteLine("Неверное значение, повторите ввод");
    }
    return number;
}


int GetSumNumber(int number)
{
    int sum = 0;
    while (number != 0)//10
    {
        sum = sum + number%10; //01
        number = number / 10; //1
                
    }
    return sum;
}

int number = GetNumber("Введите число");
int sum = GetSumNumber(number);
System.Console.WriteLine($"Сумма цифр в числе {sum}");


