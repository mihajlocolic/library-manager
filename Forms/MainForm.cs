using LibraryManager.Forms;

namespace LibraryManager
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bookTitleLabel_Click(object sender, EventArgs e)
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
