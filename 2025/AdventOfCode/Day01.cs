namespace AdventOfCode2025
{
	public class Day01
	{
		protected IFileOperations fileOperations;

		public Day01(IFileOperations fileOperations)
		{
			this.fileOperations = fileOperations;
		}

		public int Part1()
		{

			string[] input = fileOperations.ReadInput(".\\input\\01.txt");

			int position = 50;
			int zeroTimes = 0;

			foreach (string inputItem in input)
			{
				string direction = inputItem.Substring(0, 1);
				int distance = int.Parse(inputItem.Substring(1));

				if (direction == "R")
					position = position + distance;
				else
					position = position - distance;

				while (position > 99)
					position = position - 100;

				while (position < 0)
					position = 100 + position;

				if (position == 0)
					zeroTimes++;
			}

			return zeroTimes;
		}

		public int Part2()
		{

			string[] input = fileOperations.ReadInput(".\\01\\input.txt");

			int position = 50;
			int zeroTimes = 0;

			foreach (string inputItem in input)
			{
				string direction = inputItem.Substring(0, 1);
				int distance = int.Parse(inputItem.Substring(1));
				int startPosition = position;

				if (direction == "R")
					position = position + distance;
				else
					position = position - distance;

				if (position == 0)
					zeroTimes++;

				while (position > 99)
				{
					position = position - 100;
					zeroTimes++;
				}

				while (position < 0)
				{
					position = 100 + position;
					if (startPosition == 0)
						startPosition = position;
					else
					{
						zeroTimes++;
						if (position == 0)
							zeroTimes++;
					}

				}

			}

			return zeroTimes;
		}
	}
}
