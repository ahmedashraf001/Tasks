using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
	class Program
	{
		const string URL = "https://ahmedasharf.w3spaces.com/index.html?#2";
		static void Main(string[] args)
		{
			
			var task = Fetching_response_body_Async(URL);
			Console.WriteLine("Asyncmethod() have been called");

			Console.WriteLine();
			Console.WriteLine("any operation in main method while AsyncMethod() is running in beackground \n");

			task.Wait();
			Console.WriteLine("\nAsyncMethod() is now finished");

			Console.ReadLine();
		}

		public static async Task Fetching_response_body_Async(string url)
		{
			HttpClient ob = new HttpClient();

			Console.WriteLine("before Async method(long time operation)");
			string res = await ob.GetStringAsync(url);

			Console.WriteLine("Response body generated successfully >>>>>>>\n ");
			Console.WriteLine(res);
		}

	}
}
