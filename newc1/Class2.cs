using System;

public class TriangleAnalyzer : Triangle
{
    public TriangleAnalyzer(int a, int b, int c) : base(a, b, c) { }

    public TriangleAnalyzer(Triangle other) : base(other) { }

    public int GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    public int GetLongestSide()
    {
        int longest = SideA;

        if (SideB > longest)
        {
            longest = SideB;
        }

        if (SideC > longest)
        {
            longest = SideC;
        }

        return longest;
    }

    public bool IsValidTriangle()
    {
        if (SideA + SideB > SideC &&
            SideA + SideC > SideB &&
            SideB + SideC > SideA)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
