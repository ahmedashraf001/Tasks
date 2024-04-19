using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Program
	{
		static void Main(string[] args)
		{
			int x, y;
			Console.WriteLine("Enter Two numbers:-");
			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

			Console.WriteLine("Sum of the Two numbers: " + (x + y));


			Console.ReadLine();
		}
	}
}
