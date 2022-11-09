using Braille.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Braille;

public partial class MainWindow : Window
{
    List<bool> Touches;
    List<Button> buttons;
    List<TextBlock> numbers;
    ViewModel model;

    public MainWindow()
    {
        InitializeComponent();
        Touches = new List<bool>() { false, false, false, false, false, false };
        buttons = new() { t1, t2, t3, t4, t5, t6 };
        numbers = new() { numberBlock1, numberBlock2, numberBlock3, numberBlock4, numberBlock5, numberBlock6 };

        model = new(buttons, numbers);

        KeyUp += MainWindow_KeyUp;
    }

    private void MainWindow_KeyUp(object sender, KeyEventArgs e) => model.KeyUpInKeyBoard(e);
    private void t1_Click(object sender, RoutedEventArgs e) => model.Button1Click();
    private void t2_Click(object sender, RoutedEventArgs e) => model.Button2Click();
    private void t3_Click(object sender, RoutedEventArgs e) => model.Button3Click();
    private void t4_Click(object sender, RoutedEventArgs e) => model.Button4Click();
    private void t5_Click(object sender, RoutedEventArgs e) => model.Button5Click();
    private void t6_Click(object sender, RoutedEventArgs e) => model.Button6Click();

}
