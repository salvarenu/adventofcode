namespace AdventOfCode2025
{
	public class Day03
	{
		protected IFileOperations fileOperations;

		public Day03(IFileOperations fileOperations)
		{
			this.fileOperations = fileOperations;
		}

		public decimal Part1()
		{
			string[] input = fileOperations.ReadInput(".\\input\\03.txt");

			List<int> joltages = new List<int>();
			foreach (string inputItem in input)
			{
				int maxValue = 0;
				for (int i = 0; i < inputItem.Length - 1; i++)
				{
					char iValue = inputItem[i];

					for (int j = i + 1; j < inputItem.Length; j++)
					{
						char jValue = inputItem[j];

						int ijValue = int.Parse($"{iValue}{jValue}");

						if (ijValue > maxValue)
							maxValue = ijValue;
					}
				}
				joltages.Add(maxValue);

			}

			return joltages.Sum();
		}

		public decimal Part2()
		{
			string[] input = fileOperations.ReadInput(".\\input\\03.txt");

			List<decimal> joltages = new List<decimal>();
			foreach (string inputItem in input)
			{
				decimal maxValue = decimal.Parse(MaxSubsequenceNumber(inputItem, 12));
				joltages.Add(maxValue);

			}

			return joltages.Sum();
		}


		public static string MaxSubsequenceNumber(string s, int k)
		{
			if (s is null) throw new ArgumentNullException(nameof(s));
			if (k < 0 || k > s.Length) throw new ArgumentOutOfRangeException(nameof(k), "k debe estar entre 0 y la longitud de la cadena.");
			if (!s.All(char.IsDigit)) throw new ArgumentException("La cadena debe contener solo dígitos.", nameof(s));
			if (k == 0) return string.Empty;
			if (k == s.Length) return s;

			int toRemove = s.Length - k; // cuántos dígitos debemos descartar
			var stack = new List<char>(k);

			foreach (char c in s)
			{
				// Mientras el de arriba sea menor que el actual y aún podamos quitar, lo quitamos
				while (toRemove > 0 && stack.Count > 0 && stack[^1] < c)
				{
					stack.RemoveAt(stack.Count - 1);
					toRemove--;
				}
				stack.Add(c);
			}

			// Si no hemos quitado suficiente, recortamos por el final
			if (stack.Count > k)
				stack.RemoveRange(k, stack.Count - k);

			return new string(stack.ToArray());
		}

	}
}
