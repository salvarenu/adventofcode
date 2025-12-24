using Moq;

namespace AdventOfCode2025.Tests
{
	public class Day04Tests
	{
		[Fact]
		public void Day04Part1Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day04TestInput());
			Day04 day = new Day04(fileOperationsMock.Object);

			decimal result = day.Part1();

			Assert.Equal(13, result);
		}

		private string[] Day04TestInput()
		{
			return
				[
				"..@@.@@@@.",
				"@@@.@.@.@@",
				"@@@@@.@.@@",
				"@.@@@@..@.",
				"@@.@@@@.@@",
				".@@@@@@@.@",
				".@.@.@.@@@",
				"@.@@@.@@@@",
				".@@@@@@@@.",
				"@.@.@@@.@."
			];
		}

		[Fact]
		public void Day04Part2Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day04TestInput());
			Day04 day = new Day04(fileOperationsMock.Object);

			decimal result = day.Part2();

			Assert.Equal(43, result);
		}
	}
}
