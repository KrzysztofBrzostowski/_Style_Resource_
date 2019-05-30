using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MathDemo
{
	class Program
	{
		[DllImport("Math.dll")]
		static extern float Add(float a, float b);

		static void Main(string[] args)
		{
			Console.WriteLine(Add(2, 3));
			Console.Read();
		}
	}
}
