namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int fct = Factorial(5);
		}

		public static int Factorial(int i)
		{
			if (i == 0) return 1;
			else return i * Factorial(i - 1);
		}
	}
}
