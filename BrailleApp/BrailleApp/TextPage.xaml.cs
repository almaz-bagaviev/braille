using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrailleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextPage : ContentPage
    {

        public TextPage(string text)
        {
            InitializeComponent();
            textLabel.Text = text;
        }
    }
}