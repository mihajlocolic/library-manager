using System.Data;
using LibraryManager.Models;

namespace LibraryManager.Forms
{
    public partial class BorrowForm : Form
    {

        List<Member> members;
        MainForm mainForm;
        DataGridViewRow selectedBookRow;
        public BorrowForm(List<Member> m, MainForm mf, DataGridViewRow sbr)
        {
            this.members = m;
            this.mainForm = mf;
            this.selectedBookRow = sbr;
            InitializeComponent();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> membersDict = new Dictionary<int, string>();
            foreach (Member m in members)
            {
                membersDict.Add((int)m.Id, m.FirstName + " " + m.LastName);
            }
            borrowersComboBox.DataSource = membersDict.ToArray();

        }

        private void borrowConfirmBtn_Click(object sender, EventArgs e)
        {
            int? selectedMemberIndex = borrowersComboBox.SelectedIndex;
            //Console.WriteLine("Selected member: " + selectedMemberIndex);
            if (selectedMemberIndex != null)
            {
                DataRow selectedBook;
                // Update book object and grid view

                if (selectedBookRow != null)
                {
                    // Solution found on stack overflow.
                    // https://stackoverflow.com/questions/1822314/how-do-i-get-a-datarow-from-a-row-in-a-datagridview/1822337
                    selectedBook = (selectedBookRow.DataBoundItem as DataRowView).Row;

                    if (selectedBook != null)
                    {
                        Member? mbr = mainForm.members.Find(x => x.Id == selectedMemberIndex + 1);
                        if (mbr != null)
                        {
                            selectedBook["Borrower"] = mbr;
                            selectedBook["Status"] = Book.BookStatus.Borrowed;

                            mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Status"].Value = selectedBook["Status"];
                            mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Borrower"].Value = mbr.FirstName + " " + mbr.LastName;
                            Book? tmpBook = mainForm.books.Where(x => x.Id == (int)selectedBook["Id"]).FirstOrDefault();

                            // Saving changes in the books list and json file.
                            if (tmpBook != null)
                            {
                                int bookIdx = mainForm.books.FindIndex(x => x.Id == tmpBook.Id);
                                Console.WriteLine(bookIdx);
                                if (bookIdx != -1)
                                {
                                    mainForm.books[bookIdx].Borrower = mbr;
                                    mainForm.books[bookIdx].Status = Book.BookStatus.Borrowed;

                                    mainForm.SaveBooksChanges();
                                    Close();
                                }

                            }
                            else
                            {
                                Console.WriteLine("tmpBook was null");
                            }
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("selectedBook is null!");
                    }
                }
                else
                {
                    Console.WriteLine("selectedBookRow is null!");
                }

            }
            else
            {
                Close();
                throw new Exception("Selected member was null.");
                // return error
            }
        }

        private void cancelBorrowBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DataRow dataRow;

            // Doesn't work with multiple rows selected, it's a logic that's not implemented.
            dataRow = (selectedBookRow.DataBoundItem as DataRowView).Row;
            
            if(dataRow != null)
            {
                dataRow["Borrower"] = string.Empty;
                dataRow["Status"] = Book.BookStatus.Available;



                mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Status"].Value = dataRow["Status"];
                mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Borrower"].Value = string.Empty;
                Book? tmpBook = mainForm.books.Where(x => x.Id == (int)dataRow["Id"]).FirstOrDefault();


                if (tmpBook != null)
                {
                    int bookIdx = mainForm.books.FindIndex(x => x.Id == tmpBook.Id);
                   
                    if (bookIdx != -1)
                    {
                        mainForm.books[bookIdx].Borrower = null;
                        mainForm.books[bookIdx].Status = Book.BookStatus.Available;

                        mainForm.SaveBooksChanges();
                        Close();
                    }

                }
                else
                {
                    Console.WriteLine("tmpBook was null");
                }

      
            }


        }
    }
}

