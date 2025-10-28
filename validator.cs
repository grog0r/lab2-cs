using System;

namespace lab2_siu;
public class Validator
{
    // ПРОВЕРКИ НА ВВОД

    // Проверка на ввод числа
    public double readDouble(string inp)
    {
        Console.Write(inp);
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.Write("Неверный ввод, введите число: ");
        }
    }

    // Проверка на ввод цифры
    public char readChar(string inp)
    {
        Console.Write(inp);
        while (true)
        {
            string input = Console.ReadLine();
            if (input != null && input.Length == 1 && input[0] >= '0' && input[0] <= '9')
            {
                return input[0];
            }
            Console.Write("Неверный ввод, введите ОДНУ цифру от 0 до 9: ");
        }
    }

    // Проверка на ввод целого числа
    public int readInt(string inp)
    {
        int result;
        Console.Write(inp);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Неверный ввод, введите целое число: ");
        }
        return result;
    }

    // Проверка на ввод целого числа в диапазоне
    public int readIntInRange(string inp, int min, int max)
    {
        int result;
        Console.Write(inp);
        while (!int.TryParse(Console.ReadLine(), out result) || result < min || result > max)
        {
            Console.Write($"Ошибка ввода, введите целое число от {min} до {max}: ");
        }
        return result;
    }
}