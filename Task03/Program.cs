using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Rectangle01 length & width:");
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Circle radius");
			double r = double.Parse(Console.ReadLine());


			Rectangle Rec = new Rectangle(x, y);
			circle circ = new circle(r);

			Console.WriteLine("Rectangle Area: " + Rec.CalculateArea());
			Console.WriteLine("Circle Area: " + circ.CalculateArea());

			Console.ReadLine();
		}
	}


	public abstract class shape
	{
		public abstract double CalculateArea();
	}

	public class Rectangle : shape
	{
		public double length { set; get; }
		public double width { set; get; }
		public Rectangle(double x, double y)
		{
			length = x;
			width = y;
		}
		public override double CalculateArea()
		{
			return length * width;
		}
	}
	public class circle : shape
	{
		public double radius { set; get; }
		public circle(double r)
		{
			radius = r;
		}
		public override double CalculateArea()
		{
			return 3.14 * radius * radius;
		}

	}


}
