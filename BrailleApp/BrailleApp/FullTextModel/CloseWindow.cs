using BrailleApp.Model;

namespace BrailleApp.FullTextModel
{
    public class CloseWindow
    {
        public static bool isCloseTextWindow;
        ViewModel model;

        public void TextWindowClose()
        {
            model = new ViewModel();
            model.Timer(true);
            isCloseTextWindow = true;
        }

        public void ClearText()
        {
            if (isCloseTextWindow) ViewModel.EnteredText.Clear();
            ViewModel.EnteredText.Clear();
            isCloseTextWindow = false;
        }
    }
}