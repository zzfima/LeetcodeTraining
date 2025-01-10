namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int fct = Factorial(3);
		}

		public static int Factorial(int i)
		{
			if (i == 1) return 1;
			else return i * Factorial(i - 1);
		}
	}
}
