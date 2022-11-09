using System.Windows;
using System.ComponentModel;
using Braille.FullTextModel;

namespace Braille.Views;

public partial class FullTextWindow : Window
{
    public static bool isCloseTextWindow;
    
    public FullTextWindow()
    {
        InitializeComponent();
        isCloseTextWindow = false;

        this.Closing += FullTextWindow_Closing;
    }

    private void FullTextWindow_Closing(object? sender, CancelEventArgs e)
    {
        CloseWindow.TextWindowClose();
    }

}
