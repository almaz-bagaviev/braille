using System.Collections.Generic;

namespace Braille.MainModel;

public class ABCRepository
{
    public List<ABC> RusAbc { get; set; }
    public List<ABC> EngAbc { get; set; }
    public List<ABC> NumbersAbc { get; set; }
    public List<ABC> SymbolsAbc { get; set; }

    public ABC NullSymbol { get; set; }
    public ABCRepository()
    {
        NullSymbol = new("*", 0);

        RusAbc = new List<ABC>()
        {
            new ABC("а", 1 ),
            new ABC("б", 12),
            new ABC("в",2456 ),
            new ABC("г", 1245 ),
            new ABC("д", 145 ),
            new ABC("е", 15 ),
            new ABC("ё", 16 ),
            new ABC("ж", 245 ),
            new ABC("з", 1356 ),
            new ABC("и", 24 ),
            new ABC("й", 12346 ),
            new ABC("к", 13 ),
            new ABC("л", 123 ),
            new ABC("м", 134 ),
            new ABC("н", 1345 ),
            new ABC("о", 135 ),
            new ABC("п", 1234 ),
            new ABC("р", 1235 ),
            new ABC("с", 234 ),
            new ABC("т", 2345 ),
            new ABC("у", 136 ),
            new ABC("ф", 124 ),
            new ABC("ч", 125 ),
            new ABC("ц", 14 ),
            new ABC("ч", 12345 ),
            new ABC("ш", 156 ),
            new ABC("щ", 1346 ),
            new ABC("ъ", 12356 ),
            new ABC("ы", 2346 ),
            new ABC("ь", 23456 ),
            new ABC("э", 246 ),
            new ABC("ю", 1256 ),
            new ABC("я", 1246 )
        };

        EngAbc = new List<ABC>()
        {
            new ABC("a",1),
            new ABC("b", 12),
            new ABC("c", 14),
            new ABC("d", 145),
            new ABC("e", 15),
            new ABC("f", 124),
            new ABC("g", 1245),
            new ABC("h", 125),
            new ABC("i", 24),
            new ABC("j", 245),
            new ABC("k", 13),
            new ABC("l", 123),
            new ABC("m", 134),
            new ABC("n", 1345),
            new ABC("o", 135),
            new ABC("p", 1234),
            new ABC("q", 12345),
            new ABC("r", 1235),
            new ABC("s", 234),
            new ABC("t", 2345),
            new ABC("u", 136),
            new ABC("v", 1236),
            new ABC("w", 2456),
            new ABC("x", 1346),
            new ABC("y", 13456),
            new ABC("z", 1356)
        };

        NumbersAbc = new List<ABC>()
        {
            new ABC("1", 1),
            new ABC("2", 12),
            new ABC("3", 14),
            new ABC("4", 145),
            new ABC("5", 15),
            new ABC("6", 124),
            new ABC("7", 1245),
            new ABC("8", 125),
            new ABC("9", 136),
            new ABC("0", 124),
        };

        SymbolsAbc = new List<ABC>()
        {
            new ABC("<<", 236),
            new ABC(">>", 356),
            new ABC("-", 36),
            new ABC(".", 256),
            new ABC(",", 2),
            new ABC("?", 26),
            new ABC("!", 235),
            new ABC(";", 23),
            new ABC("(", 126),
            new ABC(")", 345),
            new ABC("()", 2356)
        };
    }
}
