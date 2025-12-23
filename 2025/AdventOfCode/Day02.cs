
namespace AdventOfCode2025
{
	public class Day02
	{
		protected IFileOperations fileOperations;

		public Day02(IFileOperations fileOperations)
		{
			this.fileOperations = fileOperations;
		}

		public decimal Part1()
		{
			string[] input = fileOperations.ReadInput(".\\input\\02.txt");

			string[] groupIds = input[0].Split(',');

			List<decimal> wrongIds = new List<decimal>();

			foreach (var group in groupIds)
			{
				string[] ids = group.Split("-");
				decimal firstId = decimal.Parse(ids[0]);
				decimal lastId = decimal.Parse(ids[1]);

				for (decimal id = firstId; id <= lastId; id++)
				{
					if (HasRepeatedPattern(id))
						wrongIds.Add(id);
				}
			}

			return wrongIds.Sum();
		}

		private bool HasRepeatedPattern(decimal id)
		{
			string strId = id.ToString();

			if (strId.Length % 2 == 0)
			{
				int halfLength = strId.Length / 2;
				return strId.Substring(0, halfLength).Equals(strId.Substring(halfLength));
			}

			return false;
		}

		public decimal Part2()
		{
			string[] input = fileOperations.ReadInput(".\\input\\02.txt");

			string[] groupIds = input[0].Split(',');

			List<decimal> wrongIds = new List<decimal>();

			foreach (var group in groupIds)
			{
				string[] ids = group.Split("-");
				decimal firstId = decimal.Parse(ids[0]);
				decimal lastId = decimal.Parse(ids[1]);

				for (decimal id = firstId; id <= lastId; id++)
				{
					if (HasRepeatedPatternMoreThan2(id))
						wrongIds.Add(id);
				}
			}

			return wrongIds.Sum();
		}

		private bool HasRepeatedPatternMoreThan2(decimal id)
		{
			string strId = id.ToString();

			for (int i = 1; i <= strId.Length / 2; i++)
			{
				List<string> numbers = SplitInChunks(strId, i);
				if (numbers.All(x => x == numbers[0]))
					return true;
			}

			return false;
		}


		/// <summary>
		/// Divide un string en subcadenas de longitud fija.
		/// </summary>
		/// <param name="input">Cadena original.</param>
		/// <param name="chunkSize">Longitud de cada subcadena.</param>
		/// <returns>Lista de subcadenas.</returns>
		public static List<string> SplitInChunks(string input, int chunkSize)
		{
			// Validaciones
			if (string.IsNullOrEmpty(input))
				throw new ArgumentException("La cadena no puede ser nula o vacía.");
			if (chunkSize <= 0)
				throw new ArgumentException("La longitud de cada subcadena debe ser mayor que cero.");

			var result = new List<string>();

			for (int i = 0; i < input.Length; i += chunkSize)
			{
				// Si queda menos de chunkSize, toma lo que haya
				int length = Math.Min(chunkSize, input.Length - i);
				result.Add(input.Substring(i, length));
			}

			return result;
		}

	}
}
