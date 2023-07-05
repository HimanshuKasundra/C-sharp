// Create a class Furniture with material ,price as data members. Create
// another class Table with Height , surface_area as data members. Write a
// program to implement single inheritance
using System;

class Furniture
{
    private string? material;
    private double price;
}
class Table : Furniture{
    double height;

    double surface_area;
    public Table(string Material, double Price, double Height, double SurfaceArea)
        {
            this.material = Material;
            this.price = Price;
            this.height = Height;
            this.surface_areaurfaceArea = SurfaceArea;
        }
} 
class Program
{
    static void Main(string[] args)
    {
        Table t = new Table("Material", 50000, 120, 1200);
            t.displayData();
    }
}
