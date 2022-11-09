using Braille.Views;
using System.Text;
using System.Threading;

namespace Braille.MainTextModel;

public static class FinalText
{
    public static void FullTextOpenWindow(StringBuilder stringBuilder)
    {
        Thread.Sleep(3000);
        FullTextWindow textWindow = new();
        textWindow.fullText.Text = stringBuilder.ToString();
        textWindow.ShowDialog();
    }
}
