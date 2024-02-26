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
            if (value < 1) percent = value; // switched conditional around for better readibility
            else percent = value / 100;
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