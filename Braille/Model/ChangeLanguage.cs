using Braille.Params;

namespace Braille.Model;

public static class ChangeLanguage
{
    public static Alphabet ChangeLanguageOrSymbolsParams(Alphabet alphabet, int clickCountForButton2, int clickCountForButton5)
    {
        if (clickCountForButton2 == 1 && clickCountForButton5 == 2) alphabet = Alphabet.Rus;
        else if (clickCountForButton2 == 1 && clickCountForButton5 == 3) alphabet = Alphabet.Eng;
        else if (clickCountForButton2 == 2 && clickCountForButton5 == 1) alphabet = Alphabet.Number;
        else if (clickCountForButton2 == 2 && clickCountForButton5 == 2) alphabet = Alphabet.Symbols;

        return alphabet;
    }
}
