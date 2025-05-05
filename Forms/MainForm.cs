using System.Text.Json;
using LibraryManager.Forms;
using LibraryManager.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManager
{
    public partial class MainForm : Form
    {


        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();
        public DataGridViewRow selectedBookRow;

        public MainForm()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo booksFile = new FileInfo("books.json");
            if (booksFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader("books.json"))
                {
                    string tmp = reader.ReadToEnd();
                    books = JsonSerializer.Deserialize<List<Book>>(tmp);

                }

                LoadDataOnGridView();

            }



            FileInfo membersFile = new FileInfo("members.json");
            if (membersFile.Length > 0)
            {
                using (StreamReader reader = new StreamReader("members.json"))
                {
                    string tmp = reader.ReadToEnd();
                    members = JsonSerializer.Deserialize<List<Member>>(tmp);
                }
            }


        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world!";
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            BookAddForm bookAddForm = new BookAddForm();
            bookAddForm.ShowDialog();
        }

        private void exitBtnBooks_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            MemberAddForm memberAddForm = new MemberAddForm();
            memberAddForm.ShowDialog();
        }

        private void exitBtnMembers_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBooks();
        }

        private void UpdateBooks()
        {
            string title;
            string author;
            string genre;

            for (int i = 1; i < (dataGridView1.Rows.Count - 1); i++)
            {
                title = dataGridView1.Rows[i].Cells["title"].Value.ToString();
                author = dataGridView1.Rows[i].Cells["author"].Value.ToString();
                genre = dataGridView1.Rows[i].Cells["genre"].Value.ToString();

                Console.WriteLine(title);
                Console.WriteLine(author);
                Console.WriteLine(genre);

                if (title.Length > 0 && author.Length > 0 && genre.Length > 0)
                {
                    books[i].title = title;
                    books[i].author = author;
                    books[i].genre = genre;
                }
            }

            if (File.Exists("books.json"))
            {
                using (StreamWriter sw = new StreamWriter("books.json"))
                {
                    string json = JsonSerializer.Serialize(books);
                    sw.WriteLine(json);

                }

            }
            else
            {
                Console.WriteLine("Error: JSON file missing. Cannot save.");
            }
        }

        private void LoadDataOnGridView()
        {
            BindingSource source = new BindingSource();
            foreach (Book b in books)
            {
                source.Add(b);
            }
            dataGridView1.DataSource = source;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;
            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void removeBookBtn_Click(object sender, EventArgs e)
        {
            var selectedBookId = selectedBookRow.Cells[0].Value;
            var foundBook = books.Find(x => x.title == selectedBookRow.Cells[1].Value.ToString());


            if (long.Equals(selectedBookId, foundBook.id))
            {
                dataGridView1.Rows.RemoveAt(selectedBookRow.Index);
                books.Remove(foundBook);
    
            } else
            {
                Console.WriteLine("Matching book not found in database.");
            }

                SaveBooksChanges();
        }

        private void SaveBooksChanges()
        {
            if (File.Exists("books.json"))
            {
                using (StreamWriter sw = new StreamWriter("books.json"))
                {
                    string json = JsonSerializer.Serialize(books);
                    sw.WriteLine(json);

                }
            }
            else
            {
                Console.WriteLine("Error: JSON file missing. Cannot save.");
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            selectedBookRow = selectedRow;
        }
    }
}
