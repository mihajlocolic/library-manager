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
            int i = 0;
            foreach (Member m in members)
            {
                borrowersComboBox.Items.Insert(i, (m.FirstName + " " + m.LastName));
                i++;
            }


        }

        private void borrowConfirmBtn_Click(object sender, EventArgs e)
        {
            var m = borrowersComboBox.SelectedIndex;

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

