
namespace LibraryManager
{
    internal static class Program
    {


        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or Fdefault font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new MainForm());
        }

    }
}