using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
	class Program
	{
		static void Main(string[] args)
		{
			EventManager ob = new EventManager();
			ob.Add(); //subscribe to the event
			ob.trigger(); // trigger the event and invoking any subscribed handler 
			Console.WriteLine("----------------------------");
			ob.Remove(); //unsubscribe from the event
			ob.trigger(); // trigger the event and invoking any subscribed handler 
			Console.ReadLine();

		}
	}
}
