using System;
  

namespace Task04
{
	class EventManager
	{
		public event EventHandler EventHandeled;
		public delegate void EventHandler();

		public void EventHandler_Print_Method() { Console.WriteLine("Added"); }
		public void trigger()
		{
			EventHandeled?.Invoke();
		}

		public void Add()
		{
			EventHandeled += EventHandler_Print_Method;
		}

		public void Remove()
		{
			EventHandeled -= EventHandler_Print_Method;
		}
	}
}
