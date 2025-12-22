namespace AdventOfCode.Console
{
	internal class FileOperations : IFileOperations
	{
		public string[] ReadInput(string path)
		{
			return System.IO.File.ReadAllLines(path);
		}
	}
}
