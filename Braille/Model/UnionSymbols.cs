using System.Diagnostics;
using System.Text;

namespace Braille.Model;

public class UnionSymbols
{
    StringBuilder StringText { get; set; }

    public UnionSymbols(StringBuilder text)
    {
        this.StringText = text;
    }
    
    public void AddSymbolToText(string symbol)
    {
        if (symbol != "*") StringText.Append(symbol);
        Debug.WriteLine(StringText);
    }

    public void AddSpace()
    {
        StringText.Append(' ');
    }
}
