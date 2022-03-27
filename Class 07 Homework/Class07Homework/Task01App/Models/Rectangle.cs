using System;

namespace Task01App.Models

{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public override void GetArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {area}");
        }

        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");
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