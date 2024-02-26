// View is frontend

namespace VegetableMarket;

internal class Display{
    public double vegPrice;
    public double fruitPrice;
    public int vegWeight;
    public int fruitWeight;
    public double Revenue;
    public void Input(){
        Console.Write("Enter the price per kilo for vegetables\n>> ");
        vegPrice = double.Parse(Console.ReadLine());
        Console.Write("And now their net weight\n>> ");
        vegWeight = int.Parse(Console.ReadLine());
        Console.Write("Now the price per kilo for fruit\n>> ");
        fruitPrice = double.Parse(Console.ReadLine());
        Console.Write("And the weight\n>> ");
        fruitWeight = int.Parse(Console.ReadLine());
    }
    public void Output(){
        Console.WriteLine($"Revenue in euro: €{Revenue:f2}");
    }

    public Display(){
        Input();
    }
}