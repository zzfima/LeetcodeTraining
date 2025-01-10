namespace find_the_k_th_character_in_string_game_i
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char c = KthCharacter(5);
			Console.WriteLine("Hello, World!");
		}

		public static char KthCharacter(int k)
		{
			List<char> list = new List<char>();
			list.Add('a');

			for (int i = 0; list.Count <= k; i++)
			{
				int elementsToUpAmount = (int)Math.Pow(2, i);

				List<char> elementsToUp = new List<char>(list.GetRange(0, elementsToUpAmount));
				foreach (char element in elementsToUp)
				{
					char updated;

					if (element == 'z')
						updated = 'a';
					else
						updated = (char)((int)element + 1);

					list.Add(updated);
				}
			}

			return list[k - 1];
		}
	}
}