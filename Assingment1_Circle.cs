
using System;
					
public class Circle
{
	public static void Main()
	{
		double radius;
		double circumference;
		
		Console.WriteLine("Enter the value of radius:");
		radius = double.Parse(Console.ReadLine());
		
		circumference = 2 * Math.PI * radius;
		
		Console.WriteLine("Circumference :"+Math.Round(circumference, 2));
		Console.WriteLine("Area: "+Math.PI*(radius*radius));
	}
}
