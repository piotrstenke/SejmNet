using Xunit;

namespace SejmNet.Tests
{
	public class SejmClientTests
	{
		[Fact]
		public void TestActPdf()
		{
			SejmClient client = new SejmClient();

			client.GetActElementPdf("DU", 2017, 2, 'O', "M19920240.pdf");

			Assert.True(true);
		}
	}
}