// Model is backend
namespace VegetableMarket;


internal class Revenue{
    const double BGN_TO_EUR = 1.94; //the course of the BGN and EUR
    double vegPrice;
    double fruitPrice;
    int vegWeight;
    int fruitWeight;
    public double VegPrice{
        get{return vegPrice;}
        set{
            ArgumentOutOfRangeException.ThrowIfNegative(value); //throws an error if the value is negative
        }
    }
    public double FruitPrice{
        get{return fruitPrice;}
        set{
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            fruitPrice = value;
        }
    }
    public int VegWeight{
        get{return vegWeight;}
        set{
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            vegWeight = value;
        }
    }
    public int FruitWeight{
        get{return fruitWeight;}
        set{
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            fruitWeight = value;
        }
    }

    public Revenue(double vegPrice, double fruitPrice, int vegWeight, int fruitWeight){
        this.vegPrice = vegPrice;
        this.fruitPrice = fruitPrice;
        this.vegWeight = vegWeight;
        this.fruitWeight = fruitWeight;
    }
    public Revenue() : this(0,0,0,0){}
    public double RevenueInEuro(){
        return (vegPrice * vegWeight + fruitPrice * fruitWeight) / BGN_TO_EUR; //dividing to exchange bgn to eur
    }
}

