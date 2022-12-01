namespace Braille.MainModel;

public class ABC
{
    public string Symbol { get; set; }
    public ushort Dots { get; set; }
    public ABC(string symbol, ushort dots)
    {
        this.Symbol = symbol;
        this.Dots = dots;
    }
}
