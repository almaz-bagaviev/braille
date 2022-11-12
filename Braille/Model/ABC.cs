using Braille.Params;

namespace Braille.Model;

public static class ABC
{
    public static (string Symbol, string Dots) ConvertToBraille(Alphabet param, bool t1, bool t2, bool t3, bool t4, bool t5, bool t6)
    {
        string symbol;
        ushort dots;

        if (param == Alphabet.Rus)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) { symbol = "а"; dots = 1; }
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) { symbol = "б"; dots = 12; }
            else if (!t1 && t2 && !t3 && t4 && t5 && t6) { symbol = "в"; dots = 2456; }
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "г"; dots = 1245; }
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) { symbol = "д"; dots = 145; }
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) { symbol = "е"; dots = 15; }
            else if (t1 && !t2 && !t3 && !t4 && !t5 && t6) { symbol = "ё"; dots = 16; }
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "ж"; dots = 245; }
            else if (t1 && !t2 && t3 && !t4 && t5 && t6) { symbol = "з"; dots = 1356; }
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "и"; dots = 24; }
            else if (t1 && t2 && t3 && t4 && !t5 && t6) { symbol = "й"; dots = 12346; }
            else if (t1 && !t2 && t3 && !t4 && !t5 && !t6) { symbol = "к"; dots = 13; }
            else if (t1 && t2 && t3 && !t4 && !t5 && !t6) { symbol = "л"; dots = 123; }
            else if (t1 && !t2 && t3 && t4 && !t5 && !t6) { symbol = "м"; dots = 134; }
            else if (t1 && !t2 && t3 && t4 && t5 && !t6) { symbol = "н"; dots = 1345; }
            else if (t1 && !t2 && t3 && !t4 && t5 && !t6) { symbol = "о"; dots = 135; }
            else if (t1 && t2 && t3 && t4 && !t5 && !t6) { symbol = "п"; dots = 1234; }
            else if (t1 && t2 && t3 && !t4 && t5 && !t6) { symbol = "р"; dots = 1235; }
            else if (!t1 && t2 && t3 && t4 && !t5 && !t6) { symbol = "с"; dots = 234; }
            else if (!t1 && t2 && t3 && t4 && t5 && !t6) { symbol = "т"; dots = 2345; }
            else if (t1 && !t2 && t3 && !t4 && !t5 && t6) { symbol = "у"; dots = 136; }
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "ф"; dots = 124; }
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) { symbol = "ч"; dots = 125; }
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) { symbol = "ц"; dots = 14; }
            else if (t1 && t2 && t3 && t4 && t5 && !t6) { symbol = "ч"; dots = 12345; }
            else if (t1 && !t2 && !t3 && !t4 && t5 && t6) { symbol = "ш"; dots = 156; }
            else if (t1 && !t2 && t3 && t4 && !t5 && t6) { symbol = "щ"; dots = 1346; }
            else if (t1 && t2 && t3 && !t4 && t5 && t6) { symbol = "ъ"; dots = 12356; }
            else if (!t1 && t2 && t3 && t4 && !t5 && t6) { symbol = "ы"; dots = 2346; }
            else if (!t1 && t2 && t3 && t4 && t5 && t6) { symbol = "ь"; dots = 23456; }
            else if (!t1 && t2 && !t3 && t4 && !t5 && t6) { symbol = "э"; dots = 246; }
            else if (t1 && t2 && !t3 && !t4 && t5 && t6) { symbol = "ю"; dots = 1256; }
            else if (t1 && t2 && !t3 && t4 && !t5 && t6) { symbol = "я"; dots = 1246; }
            else { symbol = "*"; dots = 0; };
        }

        else if (param == Alphabet.Eng)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) { symbol = "a"; dots = 1; }
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) { symbol = "b"; dots = 12; }
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) { symbol = "c"; dots = 14; }
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) { symbol = "d"; dots = 145; }
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) { symbol = "e"; dots = 15; }
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "f"; dots = 124; }
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "g"; dots = 1245; }
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) { symbol = "h"; dots = 125; }
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "i"; dots = 24; }
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "j"; dots = 245; }
            else if (t1 && !t2 && t3 && !t4 && !t5 && !t6) { symbol = "k"; dots = 13; }
            else if (t1 && t2 && t3 && !t4 && !t5 && !t6) { symbol = "l"; dots = 123; }
            else if (t1 && !t2 && t3 && t4 && !t5 && !t6) { symbol = "m"; dots = 134; }
            else if (t1 && !t2 && t3 && t4 && t5 && !t6) { symbol = "n"; dots = 1345; }
            else if (t1 && !t2 && t3 && !t4 && t5 && !t6) { symbol = "o"; dots = 135; }
            else if (t1 && t2 && t3 && t4 && !t5 && !t6) { symbol = "p"; dots = 1234; }
            else if (t1 && t2 && t3 && t4 && t5 && !t6) { symbol = "q"; dots = 12345; }
            else if (t1 && t2 && t3 && !t4 && t5 && !t6) { symbol = "r"; dots = 1235; }
            else if (!t1 && t2 && t3 && t4 && !t5 && !t6) { symbol = "s"; dots = 234; }
            else if (!t1 && t2 && t3 && t4 && t5 && !t6) { symbol = "t"; dots = 2345; }
            else if (t1 && !t2 && t3 && !t4 && !t5 && t6) { symbol = "u"; dots = 136; }
            else if (t1 && t2 && t3 && !t4 && !t5 && t6) { symbol = "v"; dots = 1236; }
            else if (!t1 && t2 && !t3 && t4 && t5 && t6) { symbol = "w"; dots = 2456; }
            else if (t1 && !t2 && t3 && t4 && !t5 && t6) { symbol = "x"; dots = 1346; }
            else if (t1 && !t2 && t3 && t4 && t5 && t6) { symbol = "y"; dots = 13456; }
            else if (t1 && !t2 && t3 && !t4 && t5 && t6) { symbol = "z"; dots = 1356; }
            else { symbol = "*"; dots = 0; };
        }

        else if (param == Alphabet.Number)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) { symbol = "1"; dots = 1; }
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) { symbol = "2"; dots = 12; }
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) { symbol = "3"; dots = 14; }
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) { symbol = "4"; dots = 145; }
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) { symbol = "5"; dots = 15; }
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "6"; dots = 124; }
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "7"; dots = 1245; }
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) { symbol = "8"; dots = 125; }
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) { symbol = "9"; dots = 136; }
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) { symbol = "0"; dots = 124; }
            else { symbol = "*"; dots = 0; };
        }
        else
        {
            if (!t1 && t2 && t3 && !t4 && !t5 && t6) { symbol = "<<"; dots = 236; }
            else if (!t1 && !t2 && t3 && !t4 && t5 && t6) { symbol = ">>"; dots = 356; }
            else if (!t1 && !t2 && t3 && !t4 && !t5 && t6) { symbol = "-"; dots = 36; }
            else if (!t1 && t2 && !t3 && !t4 && t5 && t6) { symbol = "."; dots = 256; }
            else if (!t1 && t2 && !t3 && !t4 && !t5 && !t6) { symbol = ","; dots = 2; }
            else if (!t1 && t2 && !t3 && !t4 && !t5 && t6) { symbol = "?"; dots = 26; }
            else if (!t1 && t2 && t3 && !t4 && t5 && !t6) { symbol = "!"; dots = 235; }
            else if (!t1 && t2 && t3 && !t4 && !t5 && !t6) { symbol = ";"; dots = 23; }
            else if (t1 && t2 && !t3 && !t4 && !t5 && t6) { symbol = "("; dots = 126; }
            else if (!t1 && !t2 && t3 && t4 && t5 && !t6) { symbol = ")"; dots = 345; }
            else if (!t1 && t2 && t3 && !t4 && t5 && t6) { symbol = "()"; dots = 2356; }
            else { symbol = "*"; dots = 0; };
        }
        return (symbol, dots.ToString());
    }
}
