using Braille.Converter;
using Braille.MainModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrailleText;

public partial class MainWindow : Window
{
    ABCRepository abc;


    public MainWindow()
    {
        InitializeComponent();
        abc = new();

        #region

        //StackPanel stackPanel = new StackPanel();
        //Grid.SetRow(stackPanel, 0);
        //Grid.SetColumn(stackPanel, 1);

        //StackPanel stackPanel2 = new StackPanel();
        //stackPanel2.Orientation = Orientation.Horizontal;

        //stackPanel.Children.Add(stackPanel2);

        //StackPanel stackPanel3 = new StackPanel();
        //RadioButton radioButton3 = new RadioButton();
        //stackPanel3.Children.Add(radioButton3);

        //StackPanel stackPanel4 = new StackPanel();
        //RadioButton radioButton4 = new RadioButton();
        //stackPanel4.Children.Add(radioButton4);

        //stackPanel2.Children.Add(stackPanel3);
        //stackPanel2.Children.Add(stackPanel4);


        //StackPanel stackPanel21 = new StackPanel();
        //stackPanel21.Orientation = Orientation.Horizontal;

        //stackPanel.Children.Add(stackPanel21);

        //StackPanel stackPanel31 = new StackPanel();
        //RadioButton radioButton31 = new RadioButton();
        //stackPanel31.Children.Add(radioButton31);

        //StackPanel stackPanel41 = new StackPanel();
        //RadioButton radioButton41 = new RadioButton();
        //stackPanel41.Children.Add(radioButton41);

        //stackPanel21.Children.Add(stackPanel31);
        //stackPanel21.Children.Add(stackPanel41);



        //StackPanel stackPanel211 = new StackPanel();
        //stackPanel211.Orientation = Orientation.Horizontal;

        //stackPanel.Children.Add(stackPanel211);

        //StackPanel stackPanel311 = new StackPanel();
        //RadioButton radioButton311 = new RadioButton();
        //stackPanel311.Children.Add(radioButton311);

        //StackPanel stackPanel411 = new StackPanel();
        //RadioButton radioButton411 = new RadioButton();
        //stackPanel411.Children.Add(radioButton411);

        //stackPanel211.Children.Add(stackPanel311);
        //stackPanel211.Children.Add(stackPanel411);

        //mainGrid.Children.Add(stackPanel);

        #endregion

        PrintToWindow("Типичное использование статических конструкторов — это когда класс использует файл журнала");

    }


    private void PrintToWindow(string text)
    {
        string words = text.ToLower();
        int x = 0;
        List<string> wordsList = new List<string>();

        string wordsInsecondRow;
        if (words.Length < 21)
        {
            wordsList.Add(words);
        }
        else
        {

            while (words.Length >= 21)
            {
                wordsList.Add(words.Substring(0, 21));
                wordsInsecondRow = words.Substring(21);
                words = wordsInsecondRow;
                x++;
            }

        }

        for (int row = 0; row < x + 1; row++)
        {
            for (int column = 0; column < 21; column++)
            {
                StackPanel mainPanel = new();
                Grid.SetRow(mainPanel, row);
                Grid.SetColumn(mainPanel, column);

                for (int a = 0; a < 3; a++)
                {
                    StackPanel secondPanel = new();
                    secondPanel.Orientation = Orientation.Horizontal;
                    mainPanel.Children.Add(secondPanel);

                    for (int b = 0; b < 2; b++)
                    {
                        StackPanel thirdPanel = new();
                        secondPanel.Children.Add(thirdPanel);
                        RadioButton radioButton = new();
                        thirdPanel.Children.Add(radioButton);
                        //int r = 0;

                        for (int i = 0; i < words.Length; i++)
                        {
                            foreach (ABC e in abc.RusAbc)
                            {
                                if (words[i].ToString() == e.Symbol) ConvertToBraille.ButtonChecked(radioButton, e.Dots.ToString(), a, b);

                            }
                        }
                    }
                }
                mainGrid.Children.Add(mainPanel);

            }
        }
    }
}

