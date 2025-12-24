using AdventOfCode2025;

namespace AdventOfCode.Console
{
	internal class FileOperations : IFileOperations
	{
		public string[] ReadInput(string path)
		{
			return File.ReadAllLines(path);
		}
	}
}
