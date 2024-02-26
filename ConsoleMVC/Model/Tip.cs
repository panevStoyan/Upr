namespace ConsoleMVC;

internal class Tip{
    double amount;
    double percent;
    public double Amount{
        get{return amount;}
        set{amount=value;}
    }
    public double Percent{
        get{return percent;}
        set{
            if (value > 0) percent = value / 100;
            else percent = value;
        }
    }
    public Tip(double amount, double percent){
        Amount = amount;
        Percent = percent;
    }
    public Tip() : this(0,0){}
    public double CalculateTip(){
        return Amount * Percent;
    }
    public double CalculateTotal(){
        return CalculateTip() + Amount;
    }
}