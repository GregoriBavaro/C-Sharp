using System;
using Task01App.Models;

namespace Task01App
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            rectangle.Position = new int[] { 5, 110 };
            rectangle.SideA = 3;
            rectangle.SideB = 10;
            rectangle.Name = "Rectangle";
            rectangle.Color = "Yellow";

            rectangle.Move();
            rectangle.GetArea();
            rectangle.GetPerimeter();

            Circle circle = new Circle();

            circle.Position = new int[] { 20, 25 };
            circle.Radius = 5;
            circle.Name = "Circle";
            circle.Color = "Green";

            circle.Move();
            circle.GetArea();
            circle.GetPerimeter();
        }
    }
}