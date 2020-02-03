using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using log4net;
using log4net.Config;

namespace HW._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Starting application");

            Random r = new Random();
            int randomSide = r.Next(1, 10);

            Triangle triangle = new Triangle(randomSide);
            Square square = new Square(randomSide);
            Circle circle = new Circle(randomSide);
            Logger.Log.Info("Create figure");

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

            Logger.InitLogger();
            Logger.Log.Info("Write results to console");
        }
    }
}
