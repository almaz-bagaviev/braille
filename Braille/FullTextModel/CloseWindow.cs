using Braille.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille.FullTextModel;

public class CloseWindow
{
    public static bool isCloseTextWindow;

    public static void TextWindowClose()
    {
        ViewModel.timer.Start();
        isCloseTextWindow = true;
    }

    public static void ClearText()
    {
        if (isCloseTextWindow) ViewModel.EnteredText.Clear();
        ViewModel.EnteredText.Clear();
        isCloseTextWindow = false;

    }
}
