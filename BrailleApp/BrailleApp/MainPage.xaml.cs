using BrailleApp.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BrailleApp
{
    public partial class MainPage : ContentPage
    {
        ViewModel model;
        List<Button> buttons;

        public MainPage()
        {
            InitializeComponent();
            t1.TextColor = Color.Wheat;
            buttons = new List<Button>() { t1, t2, t3, t4, t5, t6 };
            model = new ViewModel(Navigation, buttons);
        }

        private void t1_Clicked(object sender, EventArgs e)
        {
            model.Button1Click();
        }

        private void t2_Clicked(object sender, EventArgs e)
        {
            model.Button2Click();
        }

        private void t3_Clicked(object sender, EventArgs e)
        {
            model.Button3Click();
        }

        private void t4_Clicked(object sender, EventArgs e)
        {
            model.Button4Click();
        }

        private void t5_Clicked(object sender, EventArgs e)
        {
            model.Button5Click();
        }

        private void t6_Clicked(object sender, EventArgs e)
        {
            model.Button6Click();
        }
    }
}
