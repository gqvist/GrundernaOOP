namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new circle
            Circle circleOne = new Circle(5);
            Circle circleTwo = new Circle(6);

            // Create new triangle
            Triangle triangleOne = new Triangle(4, 5);
            Triangle triangleTwo = new Triangle(6, 7);

            // Print out circle area
            Console.WriteLine($"The area of a circle with the radius 5 is: {circleOne.GetArea():F2}");
            Console.WriteLine($"The area of a circle with the radius 6 is: {circleTwo.GetArea():F2}");
            Console.WriteLine();

            // Print out circle circumference
            Console.WriteLine($"The circumference of a circle with the radius 5 is: {circleOne.GetCircumference():F2}");
            Console.WriteLine($"The circumference of a circle with the radius 6 is: {circleTwo.GetCircumference():F2}");
            Console.WriteLine();

            // Print out sphere volume
            Console.WriteLine($"The volume of a sphere with the radius 5 is: {circleOne.GetVolume():F2}");
            Console.WriteLine($"The volume of a sphere with the radius 6 is: {circleTwo.GetVolume():F2}");
            Console.WriteLine();

            // Print out triangle area (assuming its a right triangle)
            Console.WriteLine($"The area of a right triangle with a base of 4 and height of 5 is: {triangleOne.GetArea():F2}");
            Console.WriteLine($"The area of a right triangle with a base of 6 and height of 7 is: {triangleTwo.GetArea():F2}");
            Console.WriteLine();

            // Print out circle perimeter (assuming its a right triangle)
            Console.WriteLine($"The perimeter of a right triangle with a base of 4 and height of 5 is: {triangleOne.GetPerimeter():F2}");
            Console.WriteLine($"The perimeter of a right triangle with a base of 6 and height of 7 is: {triangleTwo.GetPerimeter():F2}");
            Console.WriteLine();


        }
    }
}
