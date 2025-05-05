using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManager.Forms
{
    public partial class BookAddForm : Form
    {
        List<Book> books = new List<Book>();
        public BookAddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

                if (books.Count > 0) {
                    Book tmp = new(books.Last().id + 1, bookTitleText.Text, bookAuthorText.Text, bookGenreText.Text);
                    books.Add(tmp);
                }
                else
                {
                    Book tmp = new(1, bookTitleText.Text, bookAuthorText.Text, bookGenreText.Text);
                    books.Add(tmp);
                }

                SaveBooks();
                
            }
            else
            {
                bookAddErrorLabel.Text = "All fields must be populated!";
            }
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
                    Form parentForm = Application.OpenForms["Form1"];
                    if (parentForm != null) {

                        parentForm.Invalidate();
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error: JSON file missing. Cannot save.");
                }
            }
    }
}
