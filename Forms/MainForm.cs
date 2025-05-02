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
    }
}
