using BrailleApp.ErrorMessage;
using System;
using System.IO;
using System.Text;

namespace BrailleApp.FilesModel
{
    public static class FileSave
    {
        public static void SaveToFile(StringBuilder text)
        {
            string path = "MainText.txt";

            try
            {
                File.WriteAllText(path, text.ToString());
            }
            catch (Exception e)
            {
                ExceptionMessage.AddErrorExceptionToFile("SaveInfoError.json", e.Message);
            }
        }
    }
}