using NUnit.Framework;
using RiderCovLib1;

namespace RiderTestCov1Project1 {
	[TestFixture]
	public class Tests {

		[Test]
		public void greetWorks() {
			Assert.That(new Class1(), Is.Not.Null);
			Assert.That(new Class1().sayHi(), Is.Not.Null);
			Assert.That(new Class1().sayHi(), Is.EqualTo("Hi!"));
		}

	}
}
