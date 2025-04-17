using System;

public class Triangle
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public Triangle(int a, int b, int c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public Triangle(Triangle other)
    {
        SideA = other.SideA;
        SideB = other.SideB;
        SideC = other.SideC;
    }

    public int MinLastDigit()
    {
        int lastA = SideA % 10;
        int lastB = SideB % 10;
        int lastC = SideC % 10;
        return Math.Min(lastA, Math.Min(lastB, lastC));
    }

    public override string ToString()
    {
        return $"Треугольник со сторонами: A={SideA}, B={SideB}, C={SideC}";
    }
}
