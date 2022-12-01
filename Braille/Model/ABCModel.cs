using Braille.MainModel;
using Braille.Params;

namespace Braille.Model;

public static class ABCModel
{
    public static ABC ConvertToBraille(Alphabet param, bool t1, bool t2, bool t3, bool t4, bool t5, bool t6)
    {
        ABCRepository r = new();
        if (param == Alphabet.Rus)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) return r.RusAbc[0];
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) return r.RusAbc[1];
            else if (!t1 && t2 && !t3 && t4 && t5 && t6) return r.RusAbc[2];
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) return r.RusAbc[3];
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) return r.RusAbc[4];
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) return r.RusAbc[5];
            else if (t1 && !t2 && !t3 && !t4 && !t5 && t6) return r.RusAbc[6];
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) return r.RusAbc[7];
            else if (t1 && !t2 && t3 && !t4 && t5 && t6) return r.RusAbc[8];
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) return r.RusAbc[9];
            else if (t1 && t2 && t3 && t4 && !t5 && t6) return r.RusAbc[10];
            else if (t1 && !t2 && t3 && !t4 && !t5 && !t6) return r.RusAbc[11];
            else if (t1 && t2 && t3 && !t4 && !t5 && !t6) return r.RusAbc[12];
            else if (t1 && !t2 && t3 && t4 && !t5 && !t6) return r.RusAbc[13];
            else if (t1 && !t2 && t3 && t4 && t5 && !t6) return r.RusAbc[14];
            else if (t1 && !t2 && t3 && !t4 && t5 && !t6) return r.RusAbc[15];
            else if (t1 && t2 && t3 && t4 && !t5 && !t6) return r.RusAbc[16];
            else if (t1 && t2 && t3 && !t4 && t5 && !t6) return r.RusAbc[17];
            else if (!t1 && t2 && t3 && t4 && !t5 && !t6) return r.RusAbc[18];
            else if (!t1 && t2 && t3 && t4 && t5 && !t6) return r.RusAbc[19];
            else if (t1 && !t2 && t3 && !t4 && !t5 && t6) return r.RusAbc[20];
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) return r.RusAbc[21];
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) return r.RusAbc[22];
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) return r.RusAbc[23];
            else if (t1 && t2 && t3 && t4 && t5 && !t6) return r.RusAbc[24];
            else if (t1 && !t2 && !t3 && !t4 && t5 && t6) return r.RusAbc[25];
            else if (t1 && !t2 && t3 && t4 && !t5 && t6) return r.RusAbc[26];
            else if (t1 && t2 && t3 && !t4 && t5 && t6) return r.RusAbc[27];
            else if (!t1 && t2 && t3 && t4 && !t5 && t6) return r.RusAbc[28];
            else if (!t1 && t2 && t3 && t4 && t5 && t6) return r.RusAbc[29];
            else if (!t1 && t2 && !t3 && t4 && !t5 && t6) return r.RusAbc[30];
            else if (t1 && t2 && !t3 && !t4 && t5 && t6) return r.RusAbc[31];
            else if (t1 && t2 && !t3 && t4 && !t5 && t6) return r.RusAbc[32];
            else return r.NullSymbol;
        }

        else if (param == Alphabet.Eng)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) return r.EngAbc[0];
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && !t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && t3 && !t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && !t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && t2 && t3 && !t4 && t5 && !t6) return r.EngAbc[0];
            else if (!t1 && t2 && t3 && t4 && !t5 && !t6) return r.EngAbc[0];
            else if (!t1 && t2 && t3 && t4 && t5 && !t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && !t4 && !t5 && t6) return r.EngAbc[0];
            else if (t1 && t2 && t3 && !t4 && !t5 && t6) return r.EngAbc[0];
            else if (!t1 && t2 && !t3 && t4 && t5 && t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && t4 && !t5 && t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && t4 && t5 && t6) return r.EngAbc[0];
            else if (t1 && !t2 && t3 && !t4 && t5 && t6) return r.EngAbc[0];
            else return r.NullSymbol;
        }

        else if (param == Alphabet.Number)
        {
            if (t1 && !t2 && !t3 && !t4 && !t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && t2 && !t3 && !t4 && !t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && !t2 && !t3 && t4 && !t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && !t2 && !t3 && t4 && t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && !t2 && !t3 && !t4 && t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && t2 && !t3 && t4 && !t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && t2 && !t3 && t4 && t5 && !t6) return r.NumbersAbc[0];
            else if (t1 && t2 && !t3 && !t4 && t5 && !t6) return r.NumbersAbc[0];
            else if (!t1 && t2 && !t3 && t4 && !t5 && !t6) return r.NumbersAbc[0];
            else if (!t1 && t2 && !t3 && t4 && t5 && !t6) return r.NumbersAbc[0];
            else return r.NullSymbol;
        }
        else
        {
            if (!t1 && t2 && t3 && !t4 && !t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && !t2 && t3 && !t4 && t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && !t2 && t3 && !t4 && !t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && !t3 && !t4 && t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && !t3 && !t4 && !t5 && !t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && !t3 && !t4 && !t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && t3 && !t4 && t5 && !t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && t3 && !t4 && !t5 && !t6) return r.SymbolsAbc[0];
            else if (t1 && t2 && !t3 && !t4 && !t5 && t6) return r.SymbolsAbc[0];
            else if (!t1 && !t2 && t3 && t4 && t5 && !t6) return r.SymbolsAbc[0];
            else if (!t1 && t2 && t3 && !t4 && t5 && t6) return r.SymbolsAbc[0];
            else return r.NullSymbol;
        }
    }
}
