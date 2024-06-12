class CarProgram {
	static void Main(string[] args)
	{

		// var car = new Car("8LQN616");

		// Upcasting: Conversion from a derived class to a base class
		// Downcasting: Conversion from a base class to a derived class
		// The "as" and "is" keyword.
		
		// Create a Car object and upcast it to a Vehicle reference
		// Upcasting: Implicit conversion from Car to Vehicle
		Vehicle vehicle = new Car("8LQN616");

		// Downcast the Vehicle reference back to a Car reference
		// Downcasting: Explicit conversion from Vehicle to Car
		// Car car = (Car)vehicle;

		if ( vehicle is Car ) {
			Car car = vehicle as Car;
			if ( car != null ) {
				car.toString();
			}
		}
	}
}
