using System;

namespace AbstractClasses {
	// "abstract" modifier:
	// indicates that a class or a member is missing implementation.

	// "virtual" method:
	// defines in a base class that can be overridden in derived classes. (It provides a default implementation.)

    public abstract class Shape {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public virtual void WhoAmI() {
			Console.WriteLine("Base Class: Shape.");
 		}
    }

	// "sealed" modifier:
	// prevent derivation of classes or overriding of methods.

	public sealed class Rectangle : Shape {
        public sealed override void Draw() {
            Console.WriteLine("Draw a rectangle!");
        }

		public override void WhoAmI() {
			Console.Write("Current Class: Rectangle; ");
			base.WhoAmI();
		}
    }

	public sealed class Circle : Shape {
        public sealed override void Draw() {
            Console.WriteLine("Draw a circle!");
        }

		public override void WhoAmI() {
			Console.Write("Current Class: Circle; ");
			base.WhoAmI();
		}
    }

	class ShapeProgram {
        static void Main(string[] args) {
            Circle circle = new Circle();
            circle.Draw();
			circle.WhoAmI();

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
			rectangle.WhoAmI();
        }
    }
}
