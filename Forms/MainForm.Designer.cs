using System.ComponentModel;
using System.Data.Common;
using System.Text.Json;
using LibraryManager.Models;

namespace LibraryManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            removeBookBtn = new Button();
            label1 = new Label();
            exitBtnBooks = new Button();
            addBookBtn = new Button();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            exitBtnMembers = new Button();
            removeMemberBtn = new Button();
            addMemberBtn = new Button();
            bookStatus = new DataGridViewTextBoxColumn();
            bookGenre = new DataGridViewTextBoxColumn();
            bookAuthor = new DataGridViewTextBoxColumn();
            bookTitle = new DataGridViewTextBoxColumn();
            bookId = new DataGridViewTextBoxColumn();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(-3, 0);
            tabControl.Name = "tabControl";
            tabControl.RightToLeft = RightToLeft.No;
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1217, 674);
            tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(removeBookBtn);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(exitBtnBooks);
            tabPage1.Controls.Add(addBookBtn);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1209, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1186, 508);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged_1;
            // 
            // removeBookBtn
            // 
            removeBookBtn.Location = new Point(248, 546);
            removeBookBtn.Name = "removeBookBtn";
            removeBookBtn.Size = new Size(157, 48);
            removeBookBtn.TabIndex = 9;
            removeBookBtn.Text = "Remove";
            removeBookBtn.UseVisualStyleBackColor = true;
            removeBookBtn.Click += removeBookBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(788, 558);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // exitBtnBooks
            // 
            exitBtnBooks.Location = new Point(1011, 546);
            exitBtnBooks.Name = "exitBtnBooks";
            exitBtnBooks.Size = new Size(157, 48);
            exitBtnBooks.TabIndex = 7;
            exitBtnBooks.Text = "Exit";
            exitBtnBooks.UseVisualStyleBackColor = true;
            exitBtnBooks.Click += exitBtnBooks_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(38, 546);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(157, 48);
            addBookBtn.TabIndex = 6;
            addBookBtn.Text = "Add";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(exitBtnMembers);
            tabPage2.Controls.Add(removeMemberBtn);
            tabPage2.Controls.Add(addMemberBtn);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1209, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Members";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.MenuBar;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1186, 500);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
            // 
            // exitBtnMembers
            // 
            exitBtnMembers.Location = new Point(1018, 548);
            exitBtnMembers.Name = "exitBtnMembers";
            exitBtnMembers.Size = new Size(151, 46);
            exitBtnMembers.TabIndex = 7;
            exitBtnMembers.Text = "Exit";
            exitBtnMembers.UseVisualStyleBackColor = true;
            exitBtnMembers.Click += exitBtnMembers_Click;
            // 
            // removeMemberBtn
            // 
            removeMemberBtn.Location = new Point(243, 545);
            removeMemberBtn.Name = "removeMemberBtn";
            removeMemberBtn.Size = new Size(151, 49);
            removeMemberBtn.TabIndex = 6;
            removeMemberBtn.Text = "Remove";
            removeMemberBtn.UseVisualStyleBackColor = true;
            removeMemberBtn.Click += removeMemberBtn_Click;
            // 
            // addMemberBtn
            // 
            addMemberBtn.Location = new Point(41, 545);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(151, 49);
            addMemberBtn.TabIndex = 0;
            addMemberBtn.Text = "Add";
            addMemberBtn.UseVisualStyleBackColor = true;
            addMemberBtn.Click += addMemberBtn_Click;
            // 
            // bookStatus
            // 
            bookStatus.HeaderText = "Status";
            bookStatus.MinimumWidth = 8;
            bookStatus.Name = "bookStatus";
            bookStatus.Width = 150;
            // 
            // bookGenre
            // 
            bookGenre.HeaderText = "Genre";
            bookGenre.MinimumWidth = 8;
            bookGenre.Name = "bookGenre";
            bookGenre.Width = 150;
            // 
            // bookAuthor
            // 
            bookAuthor.HeaderText = "Author";
            bookAuthor.MinimumWidth = 8;
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Width = 150;
            // 
            // bookTitle
            // 
            bookTitle.HeaderText = "Title";
            bookTitle.MinimumWidth = 8;
            bookTitle.Name = "bookTitle";
            bookTitle.Width = 150;
            // 
            // bookId
            // 
            bookId.HeaderText = "Id";
            bookId.MinimumWidth = 8;
            bookId.Name = "bookId";
            bookId.Width = 150;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1213, 673);
            Controls.Add(tabControl);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Library Manager";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button exitBtnBooks;
        private Button addBookBtn;
        private Label label1;
        private Button addMemberBtn;
        private Button removeMemberBtn;
        private Button removeBookBtn;
        private Button exitBtnMembers;
        private DataGridViewTextBoxColumn bookId;
        private DataGridViewTextBoxColumn bookTitle;
        private DataGridViewTextBoxColumn bookAuthor;
        private DataGridViewTextBoxColumn bookGenre;
        private DataGridViewTextBoxColumn bookStatus;
        public DataGridView dataGridView1;
        public DataGridView dataGridView2;
       
    }
}
