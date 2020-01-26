using System;

namespace HW._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Ура заработало!");

            Random r = new Random();
            int randomSide = r.Next(1, 10);

            Triangle triangle = new Triangle(randomSide);
            Square square = new Square(randomSide);
            Circle circle = new Circle(randomSide);

           double[] figuresArray = new double[3];
            
            for(int i =0; i < figuresArray.Length; i++)
            {
                figuresArray[i] = triangle.CountTriangleArea(randomSide);
                if(i == 1)
                {
                    figuresArray[i] = square.CountSquareArea(randomSide);
                }
                else if(i == 2)
                {
                    figuresArray[i] = circle.CountCircleArea(randomSide);
                }
            }

            Console.WriteLine($"Triangle area equals {figuresArray[0]}. " +
                                $"\nSquare area equals {figuresArray[1]}. " +
                                $"\nCircle area equals {figuresArray[2]}.");
        }
    }
}
