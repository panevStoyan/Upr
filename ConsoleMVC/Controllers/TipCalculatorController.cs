namespace ConsoleMVC;

internal class TipCalculatorController{
    private Tip tip;
    private Display display;

    public TipCalculatorController(){
        display = new();
        tip = new(display.Amount, display.Percent);
        display.TipAmount = tip.CalculateTip();
        display.Total = tip.CalculateTotal();
        display.ShowTipAndTotal();
    }
}