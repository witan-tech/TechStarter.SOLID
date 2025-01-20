using TechStarter.SOLID._3___LiskovSubstitution.Solution;

internal class Program
{
    private static void Main(string[] args)
    {
        //  LSP Problem
        //Apple apple = new Orange();
        //Console.WriteLine(apple.GetColor());
        //Console.ReadLine();

        // LSP Solution

        IFruit fruit = new Orange();
        Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
        fruit = new Apple();
        Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
        Console.ReadKey();
    }
}