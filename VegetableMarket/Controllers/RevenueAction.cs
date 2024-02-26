// Controller connects backend and frontend

namespace VegetableMarket;

internal class RevenueActionController{
    Revenue revenue;
    Display display;

    public RevenueActionController(){
        display = new();
        revenue = new(display.vegPrice, display.fruitPrice, display.vegWeight, display.fruitWeight);
        display.Revenue = revenue.RevenueInEuro();
        display.Output();
    }
}