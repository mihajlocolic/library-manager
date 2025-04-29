namespace LibraryManager
{
    internal static class Program
    {

        private static string books = "books.json";
        private static string members = "members.json";

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or Fdefault font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            if (!File.Exists(books))
            {
                FileStream booksJson = File.Create(books);
                booksJson.Close();

                File.WriteAllText(books, "[]");
                
            }

            if(!File.Exists(members))
            {
                FileStream membersJson = File.Create(members);
                membersJson.Close();

                File.WriteAllText(members, "[]");
                
            }
                
            Application.Run(new MainForm());
        }
    }
}