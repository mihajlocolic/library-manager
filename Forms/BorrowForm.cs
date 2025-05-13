using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManager.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            InitializeComponent();
            this.mainForm = mf;
            this.selectedBookRow = selectedBookRow;
            this.selectedBookRow = sbr;
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
            var m = borrowersComboBox.SelectedIndex;
            Console.WriteLine("Selected member: " + m);
            if (m != null)
            {
                DataRow selectedBook;
                // Update book object and grid view

                if (selectedBookRow != null) {
                    selectedBook = ((DataRowView) selectedBookRow.DataBoundItem).Row; // Solution found on stack overflow. (https://stackoverflow.com/questions/1822314/how-do-i-get-a-datarow-from-a-row-in-a-datagridview/1822337)

                    if (selectedBook != null)
                    {
                        Member mbr = mainForm.members.Find(x => x.Id == m + 1);
                        if (mbr != null)
                        {
                            selectedBook["Borrower"] = mbr;
                            selectedBook["Status"] = Book.BookStatus.Borrowed;
                        }


                        mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Status"].Value = selectedBook["Status"];
                        mainForm.dataGridView1.Rows[selectedBookRow.Index].Cells["Borrower"].Value = mbr.FirstName + " " + mbr.LastName;
                        Book tmpBook = mainForm.books.Where(x => x.Id == (int) selectedBook["Id"]).FirstOrDefault();

                        //Here im supposed to find that book and set the values, so i can save the borrowing changes.

                        
                        if (tmpBook != null) {
                            int bookIdx = mainForm.books.FindIndex(x => x.Id == tmpBook.Id);
                            Console.WriteLine(bookIdx);
                            if (bookIdx != -1)
                            {
                                mainForm.books[bookIdx].Borrower = mbr;
                                mainForm.books[bookIdx].Status = Book.BookStatus.Borrowed;
                            }
                            
                        } else
                        {
                            Console.WriteLine("tmpBook was null");
                        }
                            mainForm.SaveBooksChanges();
                        Close();
                    }
                    else
                    {
                        Console.WriteLine("selectedBook is null!");
                    }
                } else
                {
                    Console.WriteLine("selectedBookRow is null!");
                }          
               
            }
            else
            {
                Close();
                throw new Exception("Selected book was null.");
                // return error
            }
        }

        private void cancelBorrowBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

