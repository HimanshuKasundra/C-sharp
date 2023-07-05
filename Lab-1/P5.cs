class P5
{
    static void Main()
    {
        Console.WriteLine("1. Calculate the area of a square");
        Console.WriteLine("2. Calculate the area of a rectangle");
        Console.WriteLine("3. Calculate the area of a circle");

        Console.Write("Enter your choice (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the side length of the square: ");
                double side = Convert.ToDouble(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine("The area of the square is: " + squareArea);
                break;

            case 2:
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());
                double rectangleArea = length * width;
                Console.WriteLine("The area of the rectangle is: " + rectangleArea);
                break;

            case 3:
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine("The area of the circle is: " + circleArea);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
