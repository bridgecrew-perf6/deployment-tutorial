using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeploymentTutorial.UnitTests
{
	public class UnitTest
	{
		public bool IsItBig(int a)
		{
			return a > 1000;
		}
	}

	[TestClass()]
	public class UnitTestTests
	{
		[TestMethod()]
		public void IsItBigTest()
		{
			var p = new UnitTest();
			Assert.IsTrue(p.IsItBig(10000));
		}
	}
}
