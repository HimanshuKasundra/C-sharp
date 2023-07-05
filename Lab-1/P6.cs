using System;

class P6
{
    static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        return celsius;
    }

    static void Main()
    {
        Console.WriteLine("1. Convert Celsius to Fahrenheit");
        Console.WriteLine("2. Convert Fahrenheit to Celsius");

        Console.Write("Enter your choice (1-2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the temperature in Celsius: ");
                double celsiusTemp = Convert.ToDouble(Console.ReadLine());
                double convertedToFahrenheit = CelsiusToFahrenheit(celsiusTemp);
                Console.WriteLine("Temperature in Fahrenheit: " + convertedToFahrenheit);
                break;

            case 2:
                Console.Write("Enter the temperature in Fahrenheit: ");
                double fahrenheitTemp = Convert.ToDouble(Console.ReadLine());
                double convertedToCelsius = FahrenheitToCelsius(fahrenheitTemp);
                Console.WriteLine("Temperature in Celsius: " + convertedToCelsius);
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
