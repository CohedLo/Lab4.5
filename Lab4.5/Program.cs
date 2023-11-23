using System;

public class Converter
{
    public static int Do(float x)
    {
        int intValue = (int)x;

        if (x == 0)
        {
            return 1000;
        }
        else if (x > 0)
        {
            return intValue;
        }
        else if (x == -1)
        {
            // Для x = -1 генерируем исключение ArgumentException
            throw new ArgumentException();
        }
        else if (x < -1)
        {
            return intValue - 5;
        }
        else
        {
            //иначе возвращаем -2000
            return -2000;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            float number1 = 42.3f;
            int result1 = Converter.Do(number1);
            Console.WriteLine($"Converter.Do({number1}) = {result1}");

            float number2 = -1;
            int result2 = Converter.Do(number2);
            Console.WriteLine($"Converter.Do({number2}) = {result2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}