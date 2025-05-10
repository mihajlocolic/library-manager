using System.Data;
using System.Text.Json;
using LibraryManager.Forms;
using LibraryManager.Models;

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

            LoadDataOnGridView();
        }


        private void addBookBtn_Click(object sender, EventArgs e)
        {
            BookAddForm bookAddForm = new BookAddForm(this);
            bookAddForm.ShowDialog();


        }

        private void exitBtnBooks_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            MemberAddForm memberAddForm = new MemberAddForm(this);
            memberAddForm.ShowDialog();
        }

        private void exitBtnMembers_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            UpdateBooks();
        }

        private bool IsNullOrEmpty(Object cell)
        {
            if (cell == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateMembers()
        {
            string firstName;
            string lastName;
            string phoneNumber;

            for (int i = 1; i < (dataGridView2.Rows.Count - 1); i++)
            {

                firstName = IsNullOrEmpty(dataGridView2.Rows[i].Cells["FirstName"].Value) ? string.Empty : dataGridView2.Rows[i].Cells["FirstName"].Value.ToString();
                lastName = IsNullOrEmpty(dataGridView2.Rows[i].Cells["LastName"].Value) ? string.Empty : dataGridView2.Rows[i].Cells["LastName"].Value.ToString();
                phoneNumber = IsNullOrEmpty(dataGridView2.Rows[i].Cells["PhoneNumber"].Value) ? string.Empty : dataGridView2.Rows[i].Cells["PhoneNumber"].Value.ToString();


                members[i].FirstName = firstName;
                members[i].LastName = lastName;
                members[i].PhoneNumber = phoneNumber;

            }

            if (File.Exists("members.json"))
            {
                using (StreamWriter sw = new StreamWriter("members.json"))
                {
                    string json = JsonSerializer.Serialize(members);
                    sw.WriteLine(json);

                }

            }
            else
            {
                Console.WriteLine("Error: JSON file missing. Cannot save.");
            }
        }

        private void UpdateBooks()
        {
            string title;
            string author;
            string genre;

            for (int i = 1; i < (dataGridView1.Rows.Count - 1); i++)
            {
                title = IsNullOrEmpty(dataGridView1.Rows[i].Cells["Title"].Value) ? string.Empty : dataGridView1.Rows[i].Cells["Title"].Value.ToString();
                author = IsNullOrEmpty(dataGridView1.Rows[i].Cells["Author"].Value) ? string.Empty : dataGridView1.Rows[i].Cells["Author"].Value.ToString();
                genre = IsNullOrEmpty(dataGridView1.Rows[i].Cells["Genre"].Value) ? string.Empty : dataGridView1.Rows[i].Cells["Genre"].Value.ToString();


                books[i].Title = title;
                books[i].Author = author;
                books[i].Genre = genre;

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

            BindingSource booksSource = new BindingSource();
           
            foreach (Book b in books)
            {
                booksSource.Add(b);
            }

           
            dataGridView1.DataSource = booksSource;
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns["Status"].ReadOnly = true;
            

            BindingSource membersSource = new BindingSource();
            foreach (Member m in members)
            {
                membersSource.Add(m);
            }
            dataGridView2.DataSource = membersSource;
            dataGridView2.AutoGenerateColumns = false;


            dataGridView2.AllowDrop = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;

        }

        private void removeBookBtn_Click(object sender, EventArgs e)
        {

            Book tmpBook = (Book)selectedBookRow.DataBoundItem;

            dataGridView1.Rows.RemoveAt(selectedBookRow.Index);
            books.Remove(tmpBook);


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

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedBookRow = selectedRow;
            }

        }

        private void removeMemberBtn_Click(object sender, EventArgs e)
        {
            Member tmpMember = (Member)selectedBookRow.DataBoundItem;

            dataGridView2.Rows.RemoveAt(selectedBookRow.Index);
            members.Remove(tmpMember);


            SaveMembersChanges();

        }

        private void SaveMembersChanges()
        {
            if (File.Exists("members.json"))
            {
                using (StreamWriter sw = new StreamWriter("members.json"))
                {
                    string json = JsonSerializer.Serialize(members);
                    sw.WriteLine(json);

                }
            }
            else
            {
                Console.WriteLine("Error: JSON file missing. Cannot save.");
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMembers();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                selectedBookRow = selectedRow;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
