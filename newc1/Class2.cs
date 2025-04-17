using System;

public class TriangleAnalyzer : Triangle
{
    public TriangleAnalyzer(int a, int b, int c) : base(a, b, c) { }

    public TriangleAnalyzer(Triangle other) : base(other) { }

    public int GetPerimeter() => SideA + SideB + SideC;

    public int GetLongestSide() => Math.Max(SideA, Math.Max(SideB, SideC));

    public bool IsValidTriangle()
    {
        return (SideA + SideB > SideC) &&
               (SideA + SideC > SideB) &&
               (SideB + SideC > SideA);
    }
}
