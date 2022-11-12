using Braille.Params;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using Braille.MainTextModel;
using System.Media;
using Braille.FilesModel;
using Braille.FullTextModel;
using System.Windows.Input;
using Braille.MainDataBase;

namespace Braille.Model;

public class ViewModel
{
    List<bool> IsClickToButtons;

    List<Button> ClickButtons { get; set; }
    List<TextBlock> Blocks { get; set; }

    public static DispatcherTimer timer = new();
    int t1ClickCount;
    int t6ClickCount;

    int t2ClickCount; //
    int t5ClickCount; // needs for Change Alphabet params

    Alphabet alphabet;
    BrailleDB dB;

    public static StringBuilder EnteredText;
    UnionSymbols unionSymbols;
    public static bool firstPanelCheckIsOpen;

    public ViewModel(List<Button> clickButtons, List<TextBlock> blocks)
    {
        this.ClickButtons = clickButtons;
        this.Blocks = blocks;
        InitialIsClickBools();
        SystemSounds.Beep.Play();

        StartTimer();

        ClickCountsIsDefault();

        EnteredText = new();
        unionSymbols = new(EnteredText);
        alphabet = Alphabet.Rus;
    }

    public void ConnectionDb(string connectionString)
    {
        dB = new BrailleDB(connectionString);
    }
    public void ConnectionDb()
    {
        dB = new BrailleDB();
    }

    private void ClickCountsIsDefault()
    {
        t1ClickCount = 0;
        t6ClickCount = 0;

        t2ClickCount = 0;
        t5ClickCount = 0;
    }

    private void InitialIsClickBools()
    {
        IsClickToButtons = new List<bool>() { false, false, false, false, false, false };
    }

    private void StartTimer()
    {
        timer.Interval = new TimeSpan(0, 0, 6);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        SystemSounds.Beep.Play();
        Normalize();

        CloseWindow.ClearText();

        var symbol = ConvertToBraille();
        unionSymbols.AddSymbolToText(symbol.Sym);

        if(symbol.Sym!="*") dB.AddToDB(symbol.Sym, symbol.Dots);
        
        ChangeAlphabet();
        ButtonsClickFalse();
        ClickCountsIsDefault();

        Debug.WriteLine(alphabet);
    }

    private void ChangeAlphabet()
    {
        alphabet = ChangeLanguage.ChangeLanguageOrSymbolsParams(alphabet, t2ClickCount, t5ClickCount);
    }

    public void KeyUpInKeyBoard(KeyEventArgs e)
    {
        if (e.Key == Key.NumPad8) Button1Click();
        if (e.Key == Key.NumPad5) Button2Click();
        if (e.Key == Key.NumPad2) Button3Click();
        if (e.Key == Key.NumPad9) Button4Click();
        if (e.Key == Key.NumPad6) Button5Click();
        if (e.Key == Key.NumPad3) Button6Click();
        Debug.WriteLine(e.Key);
    }
    public void Button1Click()
    {
        IsClickToButtons[0] = true;

        ChangeTextBlockForeground(this.Blocks[0]);
        ChangeButtonBackground(this.ClickButtons[0]);

        t1ClickCount++;
        if (t1ClickCount >= 4) StopTimer();
    }

    public void Button2Click()
    {
        IsClickToButtons[1] = true;
        ChangeTextBlockForeground(this.Blocks[1]);
        ChangeButtonBackground(this.ClickButtons[1]);
        t2ClickCount++;
        Debug.WriteLine(t2ClickCount);
    }

    public void Button3Click()
    {
        IsClickToButtons[2] = true;
        ChangeTextBlockForeground(this.Blocks[2]);
        ChangeButtonBackground(this.ClickButtons[2]);
    }

    public void Button4Click()
    {
        IsClickToButtons[3] = true;
        ChangeTextBlockForeground(this.Blocks[3]);
        ChangeButtonBackground(this.ClickButtons[3]);
    }

    public void Button5Click()
    {
        IsClickToButtons[4] = true;
        ChangeTextBlockForeground(this.Blocks[4]);
        ChangeButtonBackground(this.ClickButtons[4]);
        t5ClickCount++;
    }

    public void Button6Click()
    {
        IsClickToButtons[5] = true;
        ChangeTextBlockForeground(this.Blocks[5]);
        ChangeButtonBackground(this.ClickButtons[5]);
        t6ClickCount++;
        if (t6ClickCount == 2)
        {
            unionSymbols.AddSpace();
        }
    }

    private (string Sym, string Dots) ConvertToBraille()
    {
        var result = ABC.ConvertToBraille(alphabet, IsClickToButtons[0], IsClickToButtons[1], IsClickToButtons[2], IsClickToButtons[3], IsClickToButtons[4], IsClickToButtons[5]);
        Debug.WriteLine($"{result.Symbol} {result.Dots}");
        return result;
    }

    private void ChangeTextBlockForeground(TextBlock numberTextBlock)
    {
        numberTextBlock.Foreground = new SolidColorBrush(Colors.White);
    }
    private void ChangeButtonBackground(Button clickButton)
    {
        clickButton.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(60, 60, 60));
    }

    private void Normalize()
    {
        for (int i = 0; i < this.ClickButtons.Count; i++)
        {
            this.ClickButtons[i].Background = new SolidColorBrush(Colors.Azure);
        }
        for (int i = 0; i < this.Blocks.Count; i++)
        {
            this.Blocks[i].Foreground = new SolidColorBrush(Colors.Black);
        }
    }

    private void ButtonsClickFalse()
    {
        for (int i = 0; i < IsClickToButtons.Count; i++) IsClickToButtons[i] = false;
    }

    private void StopTimer()
    {
        timer.Stop();
        FinalText.FullTextOpenWindow(EnteredText);
        FileSave.SaveToFile(EnteredText);
    }
}
