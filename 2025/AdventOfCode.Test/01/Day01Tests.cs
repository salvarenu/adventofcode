using AdventOfCode;
using Moq;

namespace AdventOfCode2025
{
	public class Day01Tests
	{
		[Fact]
		public void Day01Part1Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day01TestInput());
			Day01 day = new Day01(fileOperationsMock.Object);

			int result = day.Part1();

			Assert.Equal(3, result);
		}

		private string[] Day01TestInput()
		{
			return
			[
				"L68",
				"L30",
				"R48",
				"L5",
				"R60",
				"L55",
				"L1",
				"L99",
				"R14",
				"L82"
			];
		}

		private string[] Day01TestInput2()
		{
			return
				[
				"L150",
				"L50"
			];
		}

		[Fact]
		public void Day01Part2Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day01TestInput());
			Day01 day = new Day01(fileOperationsMock.Object);

			int result = day.Part2();

			Assert.Equal(6, result);
		}

		[Fact]
		public void Day01Part2Test2()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day01TestInput2());
			Day01 day = new Day01(fileOperationsMock.Object);

			int result = day.Part2();

			Assert.Equal(2, result);
		}
	}
}
