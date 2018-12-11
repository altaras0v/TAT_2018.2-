using System;

namespace WebDriverTask
{
    class WebDriveProgram
    {
        static void Main(string[] args)
        {
            try
            {
                WebDriver web = new WebDriver();
                web.WebDrive();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
