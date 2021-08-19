namespace RiderCovLib1 {
	public class Class1 {

		public string sayHi() {
			return "Hi!"; // covered
		}

		public string greet(string whom) {
			return $"Hi, {whom}!"; // uncovered
		}

	}
}
