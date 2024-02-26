namespace ConsoleMVC;

internal class Display{
    public double Percent{get;set;}
    public double Amount{get;set;}
    public double Total{get;set;}
    public double TipAmount{get;set;}

    void GetValues(){
        Console.Write("Enter the amount of the meal\n>> ");
        Amount = double.Parse(Console.ReadLine());
        Console.Write("Enter the percent you want to tip\n>> ");
        Percent = double.Parse(Console.ReadLine());
    }
    
    public void ShowTipAndTotal(){
        Console.WriteLine("Your tip is {0:C}", TipAmount);
        Console.WriteLine("The total will be {0:C}", Total);
    }

    public Display(){
        Percent = 0;
        Amount = 0;
        Total = 0;
        TipAmount = 0;
        GetValues();
    }

}