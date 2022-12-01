using System.Windows.Controls;

namespace Braille.Converter;

public class ConvertToBraille
{
    public static void ButtonChecked(RadioButton radioButton, string numbers, int a, int b)
    {
        if (numbers.Contains('1'))
        {
            if (a == 1 - 1 && b == 0) radioButton.IsChecked = true;
        }
        if (numbers.Contains('2'))
        {
            if (a == 2 - 1 && b == 0) radioButton.IsChecked = true;
        }
        if (numbers.Contains('3'))
        {
            if (a == 3 - 1 && b == 0) radioButton.IsChecked = true;
        }
        if (numbers.Contains('4'))
        {
            if (a == 4 - 4 && b == 1) radioButton.IsChecked = true;
        }
        if (numbers.Contains('5'))
        {
            if (a == 5 - 4 && b == 1) radioButton.IsChecked = true;
        }
        if (numbers.Contains('6'))
        {
            if (a == 6 - 4 && b == 1) radioButton.IsChecked = true;
        }
    }
}
