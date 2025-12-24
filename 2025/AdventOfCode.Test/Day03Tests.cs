using Moq;

namespace AdventOfCode2025.Tests
{
	public class Day03Tests
	{
		[Fact]
		public void Day03Part1Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day03TestInput());
			Day03 day = new Day03(fileOperationsMock.Object);

			decimal result = day.Part1();

			Assert.Equal(357, result);
		}

		private string[] Day03TestInput()
		{
			return new string[]
			{
				"987654321111111",
				"811111111111119",
				"234234234234278",
				"818181911112111"
			};
		}

		[Fact]
		public void Day03Part2Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day03TestInput());
			Day03 day = new Day03(fileOperationsMock.Object);

			decimal result = day.Part2();

			Assert.Equal(3121910778619, result);
		}
	}
}
