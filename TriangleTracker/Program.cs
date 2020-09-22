using System;
using System.Collections.Generic;
using TriangleTracker;

namespace TriangleTracker 
  {
    public class Program 
    {
      public static void Main()
      {
        Console.WriteLine("Enter side 1: ");
        int side1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side 2: ");
        int side2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        Triangle triangleCheck = new Triangle(side1, side2, side3);
        Console.WriteLine(triangleCheck.TriangleType());
      }
    }
  }

