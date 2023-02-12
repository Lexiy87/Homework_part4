// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

double GetNumber (string message)
{
    double number =0;
    System.Console.WriteLine(message);
    
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out number)&& number>0)
        {
            break;
        }
        else System.Console.WriteLine("Вы ввели неверное число, повторите ввод");
    }
    return number;
}


// System.Console.WriteLine($"{Math.Pow(number,degree)}");

void DegreeOfNumber (double number, double degree)
{
    double result=0;
    for (int i = 0; i <= degree; i++)
    {
        
        result = Math.Pow(number,i);
        

    }
    
    System.Console.WriteLine(result);
}

double number = GetNumber ("Введите число");
double degree = GetNumber ("Введите степень");

DegreeOfNumber(number, degree);
