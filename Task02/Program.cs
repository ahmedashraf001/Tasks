using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Rectangle01 length & width:");
			double x = double.Parse(Console.ReadLine());
			double y = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter Rectangle02 length & width:");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			Rectangle Rec1 = new Rectangle(x, y);
			Rectangle Rec2 = new Rectangle(a, b);

			Console.WriteLine("Rec1 area: " + Rec1.area() + " ,Rec1 perimeter: " + Rec1.perimeter());
			Console.WriteLine("Rec2 area: " + Rec2.area() + " ,Rec2 perimeter: " + Rec2.perimeter());

			Console.ReadLine();
		}
	}

	public class Rectangle
	{
		private double length { set; get; }
		private double width { set; get; }

		public Rectangle(double length, double width)
		{
			this.length = length;
			this.width = width;
		}

		public double area()
		{
			return length * width;
		}
		public double perimeter()
		{
			return (length + width) * 2;
		}

	}


}
 

