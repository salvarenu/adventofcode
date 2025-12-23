using Moq;

namespace AdventOfCode2025.Tests
{
	public class Day02Tests
	{
		[Fact]
		public void Day02Part1Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day02TestInput());
			Day02 day = new Day02(fileOperationsMock.Object);

			decimal result = day.Part1();

			Assert.Equal(1227775554, result);
		}

		private string[] Day02TestInput()
		{
			return [
				"11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124"
				];
		}


		[Fact]
		public void Day02Part2Test()
		{
			var fileOperationsMock = new Mock<IFileOperations>();
			fileOperationsMock.Setup(f => f.ReadInput(It.IsAny<string>())).Returns(Day02TestInput());
			Day02 day = new Day02(fileOperationsMock.Object);

			decimal result = day.Part2();

			Assert.Equal(4174379265, result);
		}
	}
}
