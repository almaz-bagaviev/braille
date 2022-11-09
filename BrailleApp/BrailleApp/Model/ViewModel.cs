using BrailleApp.Params;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using BrailleApp.FilesModel;
using BrailleApp.FullTextModel;
using Xamarin.Forms;
using System.Threading;

namespace BrailleApp.Model
{
    public class ViewModel
    {
        List<bool> IsClickToButtons;
        List<Button> ClickButtons { get; set; }

        int t1ClickCount;
        int t6ClickCount;

        int t2ClickCount; //
        int t5ClickCount; // needs for Change Alphabet params

        public static bool isTimer;

        Alphabet alphabet;

        public INavigation Navigation { get; set; }

        public static StringBuilder EnteredText;
        UnionSymbols unionSymbols;
        public static bool firstPanelCheckIsOpen;

        public ViewModel(INavigation Navigation, List<Button> clickButtons)
        {
            this.ClickButtons = clickButtons;
            this.Navigation = Navigation;

            InitialIsClickBools();
            //SystemSounds.Beep.Play();
            isTimer = true;

            Timer(isTimer);

            ClickCountsIsDefault();

            EnteredText = new StringBuilder();
            unionSymbols = new UnionSymbols(EnteredText);
            alphabet = Alphabet.Rus;
        }
        public ViewModel()
        {
        }

       public void Timer(bool check)
        {
            bool excuteTimer = check;

            Device.StartTimer(new TimeSpan(0, 0, 6), () =>
            {
                if (check)
                {
                    //SystemSounds.Beep.Play();
                    Normalize();
                    CloseWindow closeWindow = new CloseWindow();
                    closeWindow.TextWindowClose();
                    closeWindow.ClearText();

                    string symbol = ConvertToBraille();
                    unionSymbols.AddSymbolToText(symbol);
                    ChangeAlphabet();
                    ButtonsClickFalse();
                    ClickCountsIsDefault();

                    Debug.WriteLine(alphabet);
                    return true; // runs again, or false to stop
                }
                return false;
            });
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

        private void ChangeAlphabet()
        {
            alphabet = ChangeLanguage.ChangeLanguageOrSymbolsParams(alphabet, t2ClickCount, t5ClickCount);
        }
        public void Button1Click()
        {
            IsClickToButtons[0] = true;
            ChangeButtonProp(this.ClickButtons[0]);

            t1ClickCount++;
            if (t1ClickCount >= 4) StopTimer();
        }

        public void Button2Click()
        {
            IsClickToButtons[1] = true;
            ChangeButtonProp(this.ClickButtons[1]);
            t2ClickCount++;
            Debug.WriteLine(t2ClickCount);
        }

        public void Button3Click()
        {
            IsClickToButtons[2] = true;
            ChangeButtonProp(this.ClickButtons[2]);
        }

        public void Button4Click()
        {
            IsClickToButtons[3] = true;
            ChangeButtonProp(this.ClickButtons[3]);
        }

        public void Button5Click()
        {
            IsClickToButtons[4] = true;
            ChangeButtonProp(this.ClickButtons[4]);
            t5ClickCount++;
        }

        public void Button6Click()
        {
            IsClickToButtons[5] = true;
            ChangeButtonProp(this.ClickButtons[5]);
            t6ClickCount++;
            if (t6ClickCount == 2)
            {
                unionSymbols.AddSpace();
            }
        }

        private string ConvertToBraille()
        {
            var result = ABC.ConvertToBraille(alphabet, IsClickToButtons[0], IsClickToButtons[1], IsClickToButtons[2], IsClickToButtons[3], IsClickToButtons[4], IsClickToButtons[5]);
            Debug.WriteLine($"{result.Symbol} {result.Dots}");
            return result.Symbol;
        }
        private void ChangeButtonProp(Button clickButton)
        {
            clickButton.BackgroundColor = Color.FromRgb(60, 60, 60);
            clickButton.TextColor = Color.White;
        }

        private void Normalize()
        {
            for (int i = 0; i < this.ClickButtons.Count; i++)
            {
                this.ClickButtons[i].Background = new SolidColorBrush(Color.Azure);
                this.ClickButtons[i].TextColor = Color.Black;
            }
        }

        private void ButtonsClickFalse()
        {
            for (int i = 0; i < IsClickToButtons.Count; i++) IsClickToButtons[i] = false;
        }

        private void StopTimer()
        {
            Timer(false);
            FileSave.SaveToFile(EnteredText);
            Thread.Sleep(3000);
            this.Navigation.PushAsync(new TextPage(EnteredText.ToString()));

        }
    }
}