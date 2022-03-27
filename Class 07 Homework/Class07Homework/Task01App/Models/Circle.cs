using System;

namespace Task01App.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the circle is {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = Math.PI * Radius * 2;
            Console.WriteLine($"The perimeter of the circle is {perimeter}");
        }

        public override void Move()
        {
            int[] updatedPositions = new int[0];
            int index = 0;

            foreach (int coordinates in Position)
            {
                Array.Resize(ref updatedPositions, updatedPositions.Length + 1);
                updatedPositions[index] = coordinates + 5;
                index++;
            }

            for (int i = 0; i < updatedPositions.Length; i++)
            {
                Console.WriteLine($"At position: {updatedPositions[0]}, {updatedPositions[1]}");
                break;
            }
        }
    }
}