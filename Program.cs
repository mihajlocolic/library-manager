using System.Text.Json;
using LibraryManager.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManager
{
    internal static class Program
    {

        private static string booksPath = "books.json";
        private static string membersPath = "members.json";
        private static List<Book> books = new List<Book>();
        private static List<Member> members = new List<Member>();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or Fdefault font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


  
            ReadFromJsonFiles();
            Application.Run(new MainForm());
        }

        private static void ReadFromJsonFiles()
        {
            if (!File.Exists(booksPath))
            {
                FileStream booksJson = File.Create(booksPath);
                booksJson.Close();

                File.WriteAllText(booksPath, "[]");

            }

            if (!File.Exists(membersPath))
            {
                FileStream membersJson = File.Create(membersPath);
                membersJson.Close();

                File.WriteAllText(membersPath, "[]");
            }

            FileInfo booksFile = new FileInfo(booksPath);
            if (booksFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader(booksPath))
                {
                    string tmp = reader.ReadToEnd();
                    books = JsonSerializer.Deserialize<List<Book>>(tmp);
                }
            }

            FileInfo membersFile = new FileInfo(membersPath);
            if (membersFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader(membersPath))
                {
                    string tmp = reader.ReadToEnd();
                    members = JsonSerializer.Deserialize<List<Member>>(tmp);
                }

            }
        }
    }
}