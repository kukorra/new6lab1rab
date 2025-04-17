using System;

public static class TrianglePrinter
{
    public static void PrintTriangleInfo(Triangle triangle)
    {
        Console.WriteLine(triangle.ToString());
        Console.WriteLine($"Минимальная последняя цифра сторон: {triangle.MinLastDigit()}");
    }

    public static void PrintAnalyzerInfo(TriangleAnalyzer analyzer)
    {
        Console.WriteLine($"Периметр: {analyzer.GetPerimeter()}");
        Console.WriteLine($"Самая длинная сторона: {analyzer.GetLongestSide()}");
        Console.WriteLine($"Треугольник корректный: {(analyzer.IsValidTriangle() ? "Да" : "Нет")}");
    }

    public static void PrintDivider()
    {
        Console.WriteLine(new string('-', 40));
    }
}
