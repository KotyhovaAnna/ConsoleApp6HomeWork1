using System;

class Program
{

	static void Main(string[] args)
	{
		int[] Array = { 1, 2, 7, 19, 24, 33, 10, 48 };

		int result = 0;
		for (int i = 0; i < Array.Length; i++)

			if (Array[i] % 2 == 0)
			{
				result += Array[i];
			}

		Console.WriteLine(result);

		Console.ReadLine();
	}
}
