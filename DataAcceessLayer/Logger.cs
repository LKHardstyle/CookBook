using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    static internal class Logger
    {
        internal static void LogError(string message, DateTime dateTime)
        {
            //Create logMessage
            string logMessage = message + " | " + dateTime.ToString();

            //Gets Path to Desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Define the file name and path
            string fileName = "Logs.txt";
            string filePath = Path.Combine(path, fileName);

            //Create and write text to file
            File.WriteAllText(filePath, logMessage);
        }
    }
}
