using System.Diagnostics;
using System.IO;

namespace Braille.ErrorMessage;

public static class ExceptionMessage
{
    public static void AddErrorExceptionToFile(string path, string message)
    {
        Debug.WriteLine(message);
        File.WriteAllText(path, message);
    }
}
