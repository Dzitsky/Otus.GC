using System;
using System.Threading;

public class TrimerExample
{
	public void Start()
	{
		Timer trimer = new Timer(obj => Console.WriteLine(DateTime.Now), null, 0, 200);
		Console.WriteLine("Hello World!");

        GC.Collect();
	}
}
