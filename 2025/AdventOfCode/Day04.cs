namespace AdventOfCode2025
{
	public class Day04
	{
		protected IFileOperations fileOperations;

		public Day04(IFileOperations fileOperations)
		{
			this.fileOperations = fileOperations;
		}

		public decimal Part1()
		{
			string[] input = fileOperations.ReadInput(".\\input\\04.txt");

			int line = 0;
			int accesibleItems = 0;
			foreach (string inputItem in input)
			{
				for (int i = 0; i < inputItem.Length; i++)
				{
					if (inputItem[i] != '@')
						continue;

					int adjacents = 0;

					if (line > 0)
					{
						char upLeft = i > 0 ? input[line - 1][i - 1] : 'X';
						if (upLeft == '@')
							adjacents++;

						char up = input[line - 1][i];
						if (up == '@')
							adjacents++;

						char upRight = i < (inputItem.Length - 1) ? input[line - 1][i + 1] : 'X';
						if (upRight == '@')
							adjacents++;
					}

					char left = i > 0 ? inputItem[i - 1] : 'X';
					if (left == '@')
						adjacents++;

					char right = i < (inputItem.Length - 1) ? inputItem[i + 1] : 'X';
					if (right == '@')
						adjacents++;

					if (line < input.Length - 1)
					{
						char downLeft = i > 0 ? input[line + 1][i - 1] : 'X';
						if (downLeft == '@')
							adjacents++;

						char down = input[line + 1][i];
						if (down == '@')
							adjacents++;

						char downRight = i < inputItem.Length - 1 ? input[line + 1][i + 1] : 'X';
						if (downRight == '@')
							adjacents++;
					}


					if (adjacents < 4)
						accesibleItems++;
				}
				line++;
			}
			return accesibleItems;
		}

		public decimal Part2()
		{
			string[] input = fileOperations.ReadInput(".\\input\\04.txt");



			int totalAccesibleItems = 0;
			int accesibleItems;
			do
			{
				List<string> nextInput = new List<string>();
				accesibleItems = 0;
				int line = 0;
				foreach (string inputItem in input)
				{
					string nextItem = string.Empty;
					for (int i = 0; i < inputItem.Length; i++)
					{
						if (inputItem[i] != '@')
						{
							nextItem = nextItem + inputItem[i];
							continue;
						}

						int adjacents = 0;

						if (line > 0)
						{
							char upLeft = i > 0 ? input[line - 1][i - 1] : 'X';
							if (upLeft == '@')
								adjacents++;

							char up = input[line - 1][i];
							if (up == '@')
								adjacents++;

							char upRight = i < (inputItem.Length - 1) ? input[line - 1][i + 1] : 'X';
							if (upRight == '@')
								adjacents++;
						}

						char left = i > 0 ? inputItem[i - 1] : 'X';
						if (left == '@')
							adjacents++;

						char right = i < (inputItem.Length - 1) ? inputItem[i + 1] : 'X';
						if (right == '@')
							adjacents++;

						if (line < input.Length - 1)
						{
							char downLeft = i > 0 ? input[line + 1][i - 1] : 'X';
							if (downLeft == '@')
								adjacents++;

							char down = input[line + 1][i];
							if (down == '@')
								adjacents++;

							char downRight = i < inputItem.Length - 1 ? input[line + 1][i + 1] : 'X';
							if (downRight == '@')
								adjacents++;
						}


						if (adjacents < 4)
						{
							nextItem = nextItem + 'x';
							accesibleItems++;
						}
						else
						{
							nextItem = nextItem + '@';
						}

					}
					nextInput.Add(nextItem);
					line++;
				}
				totalAccesibleItems += accesibleItems;

				input = nextInput.ToArray();

			} while (accesibleItems > 0);

			return totalAccesibleItems;
		}
	}
}
