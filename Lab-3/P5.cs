// Write a program to Define a class Distance have data members dist1, dist2,
// dist3. Initialize the two data members using constructor and store their
// addition in third data member using function and display addition
using System;

class Distance
{
    // Member variables
    private int d1;
    private int d2;
    private int d3;


    // Constructor with default values for DA and HRA
    public Distance(int d1 , int d2)
    {
        d1 = d1;
        d2 = d2;
        d3 = d1+d2;
    }

    // Method to calculate the total salary
    public double displaySum()
    {
       
        return d3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Distance d = new Distance(1111,2222);
        d.displaySum();
    }
}
