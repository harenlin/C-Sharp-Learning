using System;

public class Vehicle
{
	private readonly string _registrationNumber;

	public Vehicle(string registrationNumber) {
		this._registrationNumber = registrationNumber;
		Console.WriteLine("The Vehicle is being initialized. {0}", registrationNumber);
	}

	public virtual void toString(){
		Console.WriteLine("Vehicle License Plate: {0}.", this._registrationNumber);
	}
}
