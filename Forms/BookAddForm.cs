using System.Text.Json;
using LibraryManager.Models;

namespace LibraryManager.Forms
{
    public partial class BookAddForm : Form
    {
        MainForm mainForm;
        List<Book> books = new List<Book>();

        public BookAddForm(MainForm mf)
        {
            InitializeComponent();
            this.mainForm = mf;
        }

        private void BookAddForm_Load(object sender, EventArgs e)
        {
            
            FileInfo booksFile = new FileInfo("books.json");
            if (booksFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader("books.json"))
                {
                    string tmp = reader.ReadToEnd();
                    books = JsonSerializer.Deserialize<List<Book>>(tmp);
                }
            }
           
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            

            if (bookTitleText.Text.Length > 0 && bookAuthorText.Text.Length > 0 && bookGenreText.Text.Length > 0)
            {
                Book tmp;
                if (books.Count > 0) {
                    tmp = new(books.Last().Id + 1, bookTitleText.Text, bookAuthorText.Text, bookGenreText.Text, Book.BookStatus.Available, null);
                    books.Add(tmp);
                }
                else
                {
                    tmp = new(1, bookTitleText.Text, bookAuthorText.Text, bookGenreText.Text, Book.BookStatus.Available, null);
                    books.Add(tmp);
                }

                
                SaveBooks();
                UpdateGridView();

            }
            else
            {
                bookAddErrorLabel.Text = "All fields must be populated!";
            }
        }

            private void UpdateGridView()
            {

                BindingSource source = new BindingSource();

                foreach (Book b in books)
                {
                    source.Add(b);
                }
                mainForm.dataGridView1.DataSource = source;
             

            }

            private void cancelAddBtn_Click(Object sender, EventArgs e) {
                Close();
            }

            private void SaveBooks()
            {
                if (File.Exists("books.json"))
                {
                    using (StreamWriter sw = new StreamWriter("books.json"))
                    {
                        string json = JsonSerializer.Serialize(books);
                        sw.WriteLine(json);
                        
                    }
                    
                    Close(); // Closing the form once the book is added and saved.
                    

            }
                else
                {
                    Console.WriteLine("Error: JSON file missing. Cannot save.");
                }
            }
    }
}
