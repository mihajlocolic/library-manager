using System.Data;
using System.Text.Json;
using LibraryManager.Forms;
using LibraryManager.Models;
using Microsoft.Win32;

namespace LibraryManager
{
    public partial class MainForm : Form
    {
        public List<Book> books = new List<Book>();
        public List<Member> members = new List<Member>();
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
            int colIdx = e.ColumnIndex;
            int rowIdx = e.RowIndex;
            string colText = dataGridView1.Columns[colIdx].HeaderText;
            if (string.IsNullOrEmpty(dataGridView1.Rows[rowIdx].Cells[colText].Value.ToString()))
            {
                // Cancels any edit on the row if the value is empty string.
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (dt != null )
                {
                    dt.Rows[rowIdx].CancelEdit();
                } else
                {
                    Console.WriteLine("ERROR: Book DataTable was somehow null when edited cell was empty string.");
                }
                

            }
            else
            {
                UpdateBook(rowIdx, colIdx);
            }
               
        }

        private void UpdateMember(int rowIdx, int colIdx)
        {
            string colHeaderText = dataGridView2.Columns[colIdx].HeaderText;
            string colValue = dataGridView2.Rows[rowIdx].Cells[colHeaderText].Value.ToString();

            if (colHeaderText.Equals("First Name"))
            {
                members[rowIdx].FirstName = colValue;
            }
            else if (colHeaderText.Equals("Last Name"))
            {
                members[rowIdx].LastName = colValue;
            }
            else if (colHeaderText.Equals("Phone Number"))
            {
                members[rowIdx].PhoneNumber = colValue;
            }

            SaveMembersChanges();
            
        }


        public void UpdateBook(int rowIdx, int colIdx)
        {
            string colHeaderText = dataGridView1.Columns[colIdx].HeaderText;
            string colValue = dataGridView1.Rows[rowIdx].Cells[colHeaderText].Value.ToString();

            if (colHeaderText.Equals("Title"))
            {
                books[rowIdx].Title = colValue;
            } else if (colHeaderText.Equals("Author"))
            {
                books[rowIdx].Author = colValue;
            } else if (colHeaderText.Equals("Genre"))
            {
                books[rowIdx].Genre = colValue;
            }

            SaveBooksChanges();
            
        }



        private void LoadDataOnGridView()
        {

            DataTable booksTable = new DataTable();

            booksTable.Columns.Add("Id", typeof(int));
            booksTable.Columns.Add("Title", typeof(string));
            booksTable.Columns.Add("Author", typeof(string));
            booksTable.Columns.Add("Genre", typeof(string));
            booksTable.Columns.Add("Status", typeof(Book.BookStatus));
            booksTable.Columns.Add("Borrower", typeof(string));

            DataRow row;
            string borrower; 
            foreach (Book b in books)
            {
               
                row = booksTable.NewRow();
                row["Id"] = b.Id;
                row["Title"] = b.Title;
                row["Author"] = b.Author;
                row["Genre"] = b.Genre;
                row["Status"] = b.Status;

                if (b.Borrower != null)
                {
                    borrower = b.Borrower.FirstName + " " + b.Borrower.LastName;
                    row["Borrower"] = borrower;
                }

                booksTable.Rows.Add(row);
                
            }

    
            dataGridView1.DataSource = booksTable;
            dataGridView1.AllowDrop = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[0].ReadOnly = true; // Id column
            dataGridView1.Columns[4].ReadOnly = true; // Status column
            dataGridView1.Columns[5].ReadOnly = true; // Borrower column


            DataTable membersTable = new DataTable();
            membersTable.Columns.Add("Id", typeof(int));
            membersTable.Columns.Add("First Name", typeof(string));
            membersTable.Columns.Add("Last Name", typeof(string));
            membersTable.Columns.Add("Phone Number", typeof(string));

            DataRow mRow;

            
            foreach (Member m in members)
            {
                mRow = membersTable.NewRow();
                mRow["Id"] = m.Id;
                mRow["First Name"] = m.FirstName;
                mRow["Last Name"] = m.LastName;
                mRow["Phone Number"] = m.PhoneNumber;

                membersTable.Rows.Add(mRow);
            
            }
            dataGridView2.DataSource = membersTable;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AllowDrop = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Columns[0].ReadOnly = true;

        }

        private void removeBookBtn_Click(object sender, EventArgs e)
        {

            DataRow tmpBook = (selectedBookRow.DataBoundItem as DataRowView).Row;
            
            
            if (tmpBook != null) {

                int bookIdx = books.FindIndex(x => x.Id == (int) tmpBook["Id"]);
                books.RemoveAt(bookIdx);
                tmpBook.Delete();


                SaveBooksChanges();
            } else
            {
                Console.WriteLine("Cannot remove null book.");
            }
            
        }

        public void SaveBooksChanges()
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
            DataRow tmpMember = (selectedBookRow.DataBoundItem as DataRowView).Row;


            if (tmpMember != null) {
                int memberIdx = members.FindIndex(x => x.Id == (int)tmpMember["Id"]);
                members.RemoveAt(memberIdx);
                tmpMember.Delete();
                SaveMembersChanges();
            } else
            {
                Console.WriteLine("Member that user tried to remove was null.");
            }

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
            int colIdx = e.ColumnIndex;
            int rowIdx = e.RowIndex;
            string colText = dataGridView2.Columns[colIdx].HeaderText;
            if (string.IsNullOrEmpty(dataGridView2.Rows[rowIdx].Cells[colText].Value.ToString()))
            {
                // Cancels any edit on the row if the value is empty string.
                DataTable dt = dataGridView2.DataSource as DataTable;

                if (dt != null)
                {
                    dt.Rows[rowIdx].CancelEdit();
                }
                else
                {
                    Console.WriteLine("ERROR: Member DataTable was somehow null when edited cell was empty string.");
                }

            }
            else
            {
                UpdateMember(rowIdx, colIdx);
            }
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

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            BorrowForm borrowForm = new BorrowForm(members, this, selectedBookRow);
            borrowForm.ShowDialog();
        }
    }
}
