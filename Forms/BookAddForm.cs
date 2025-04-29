using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Forms
{
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            if (bookTitleText.Text.Length > 0 && bookAuthorText.Text.Length > 0 && bookGenreText.Text.Length > 0)
            {
                // Logic when theres text in all the boxes
            }
            else
            { 
                // Logic when theres text missing in one of the boxes
            }
        }

            private void cancelAddBtn_Click(Object sender, EventArgs e) {
                Close();
            }
    }
}
