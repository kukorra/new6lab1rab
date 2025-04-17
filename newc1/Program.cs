using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=== Программа анализа треугольника ===\n");

        int a = InputHelper.ReadPositiveInt("Введите сторону A: ");
        int b = InputHelper.ReadPositiveInt("Введите сторону B: ");
        int c = InputHelper.ReadPositiveInt("Введите сторону C: ");

        Triangle triangle = new Triangle(a, b, c);
        TriangleAnalyzer analyzer = new TriangleAnalyzer(triangle);
        Triangle triangleCopy = new Triangle(triangle);

        Console.WriteLine("\n[Оригинальный треугольник]");
        TrianglePrinter.PrintTriangleInfo(triangle);
        TrianglePrinter.PrintDivider();

        Console.WriteLine("[Копия треугольника]");
        TrianglePrinter.PrintTriangleInfo(triangleCopy);
        TrianglePrinter.PrintDivider();

        Console.WriteLine("[Анализ треугольника]");
        TrianglePrinter.PrintAnalyzerInfo(analyzer);
        TrianglePrinter.PrintDivider();

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

static class InputHelper
{
    public static int ReadPositiveInt(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number > 0)
            {
                break;
            }
            Console.WriteLine("Ошибка: введите положительное целое число.");
        }
        return number;
    }
}
