//4.Write methods that calculate the surface of a triangle by given:
//  Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        //right triangle with sides 3, 4 and 5
        double square1 = SurfaceOfTriangle(3, 4);
        double square2 = SurfaceOfTriangle3Sides(3, 4, 5);
        double square3 = SurfaceOfTriangle2SidesAndAngle(3, 4, 90);

        Console.WriteLine(square1);
        Console.WriteLine(square2);
        Console.WriteLine(square3);
    }

    static double SurfaceOfTriangle(double a, double ha)
    {
        double surface = a * ha / 2;
        return surface;
    }

    static double SurfaceOfTriangle3Sides(double a, double b, double c)
    {

        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return surface;
    }

    static double SurfaceOfTriangle2SidesAndAngle(double a, double b, double c)
    {
        c = c * 2 * Math.PI / 360;
        double surface = Math.Sin(c) * a * b / 2;
        return surface;

    }


}
