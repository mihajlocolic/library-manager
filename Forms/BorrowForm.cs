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

namespace LibraryManager.Forms
{
    public partial class BorrowForm : Form
    {

        List<Member> members;
        MainForm mainForm;
        public BorrowForm(List<Member> m, MainForm mf)
        {
            this.members = m;
            InitializeComponent();
            this.mainForm = mf;
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Member m in members)
            {
                borrowersComboBox.Items.Insert(i, m);
                i++;
            }


        }

        private void borrowConfirmBtn_Click(object sender, EventArgs e)
        {
            Member m = (Member) borrowersComboBox.SelectedItem;

            if (m != null)
            {
                // Update book object and grid view
                Book b = (Book) mainForm.selectedBookRow.DataBoundItem;
                b.Borrower = m;
                b.Status = Book.BookStatus.Borrowed;

                mainForm.dataGridView1.Rows[mainForm.selectedBookRow.Index].Cells["Status"].Value = b.Status;
                mainForm.dataGridView1.Rows[mainForm.selectedBookRow.Index].Cells["Borrower"].Value = b.Borrower.FirstName + " " + b.Borrower.LastName;
                Close();
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

