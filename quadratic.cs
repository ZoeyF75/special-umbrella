using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        double answer, root1, root2;
        answer = Math.Sqrt((b*b) - (4*a*c));
        root1 = (-b + answer) / (2* a);
        root2 = (-b - answer) / (2* a);
        return Tuple.Create(root1, root2);
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    }
}