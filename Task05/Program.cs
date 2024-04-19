using System;

namespace Task05
{
	class Program
	{

			public delegate int MathOperation(int x, int y);
			static void Main(string[] args)
			{
				// use same method with different ways
				Print_Calc(5, 6, Sum);
				Print_Calc(20, 5, Sub);
				Print_Calc(6, 6, Mult);
				Print_Calc(9, 3, Div);
				Console.ReadLine();
			}

			public static void Print_Calc(int x, int y, MathOperation ob)
			{
				Console.WriteLine($"result= { ob(x, y) }");
			}



			public static int Sum(int x, int y)
			{
				return x + y;
			}
			public static int Sub(int x, int y)
			{
				return x - y;
			}
			public static int Mult(int x, int y)
			{
				return x * y;
			}
			public static int Div(int x, int y)
			{
				return x / y;
			}


	}
}
