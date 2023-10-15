namespace Labb5Circle
{
    internal class Program
    {

        // Angelica Lindström NET23

        static void Main(string[] args)
        {

            Console.WriteLine("Programmet skapar två cirklar:\n");
           


            Circle circle1 = new Circle("Cirkel Nr1", 5); // creates the object named cirkle nr1 with the radius of 5.
            Console.WriteLine(circle1.GetArea()); // Call the method that counts the Area of the circle
            Console.WriteLine(circle1.GetPerimeter()); // Call the method that counts the Perimeter of the circle
            Console.WriteLine(circle1.GetSphereVolume()); // Call the method that counts the volume of the cirkle as if its a sphere
            Console.WriteLine(circle1.GetSphereArea());  // Call the method that counts the are of the cirkle as if its a sphere

            Console.WriteLine(" ");

            // Same methods 

            Circle circle2 = new Circle("Cirkel Nr2", 6);   // creates the object named cirkle nr2 with the radius of 5.
            Console.WriteLine(circle2.GetArea());  // Call the method that counts the Area of the circle
            Console.WriteLine(circle2.GetPerimeter());  // Call the method that counts the Perimeter of the circle
            Console.WriteLine(circle2.GetSphereVolume());   // Call the method that counts the volume of the cirkle as if its a sphere
            Console.WriteLine(circle2.GetSphereArea());  // Call the method that counts the are of the cirkle as if its a sphere






            // Hur avrundar jag till 3 decimaler?
        }
    }

}