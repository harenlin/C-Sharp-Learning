using System;

public class Car : Vehicle
{
	public Car(string registrationNumber) : base(registrationNumber) {
		Console.WriteLine("The Car is being initialized. I called the Vehicle constructor with Licence Plate {0}!", registrationNumber);
	}

	public override void toString(){
		// Console.WriteLine("Car License Plate: {0}.", base.toString());
		Console.Write("This is a \"Car\", with the ");
		base.toString();
	}
}
