// Write a program to calculate area of a Rectangle using constructor
using System;

class Reactangle
{
    private double area;
    private double length , breadth;

    // Constructor with default values for DA and HRA
    public Reactangle(int d1 , int d2)
    {
        length = d1;
        breadth = d2;
        area = 2*length + 2*breadth;
    }

    // Method to calculate the total salary
    public double displayArea()
    {
        return area;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Reactangle r = new Reactangle(12,12);
        Console.WriteLine(r.displayArea());
    }
}
