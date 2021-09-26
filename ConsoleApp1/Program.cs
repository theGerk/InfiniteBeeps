using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (var p in Process.GetProcesses()) Console.WriteLine(p.ProcessName);

		}
	}
}
