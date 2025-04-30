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
            tableLayoutPanel1 = new TableLayoutPanel();
            bookIdLabel = new Label();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreLabel = new Label();
            bookStatusLabel = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            exitButton = new Button();
            addBookBtn = new Button();
            tabPage2 = new TabPage();
            addMemberBtn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            memberIdLabel = new Label();
            memberFirstNameLabel = new Label();
            memberLastNameLabel = new Label();
            memberPhoneLabel = new Label();
            removeMemberBtn = new Button();
            exitBtn = new Button();
            removeBookBtn = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.8817482F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.1182556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 335F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.Location = new Point(0, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1209, 482);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new Point(24, 11);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(28, 25);
            bookIdLabel.TabIndex = 1;
            bookIdLabel.Text = "Id";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Segoe UI", 9F);
            bookTitleLabel.Location = new Point(309, 11);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(44, 25);
            bookTitleLabel.TabIndex = 2;
            bookTitleLabel.Text = "Title";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Location = new Point(754, 11);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(67, 25);
            bookAuthorLabel.TabIndex = 3;
            bookAuthorLabel.Text = "Author";
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Location = new Point(979, 11);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(58, 25);
            bookGenreLabel.TabIndex = 4;
            bookGenreLabel.Text = "Genre";
            // 
            // bookStatusLabel
            // 
            bookStatusLabel.AutoSize = true;
            bookStatusLabel.Location = new Point(1114, 11);
            bookStatusLabel.Name = "bookStatusLabel";
            bookStatusLabel.Size = new Size(60, 25);
            bookStatusLabel.TabIndex = 5;
            bookStatusLabel.Text = "Status";
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
            tabPage1.Controls.Add(removeBookBtn);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(exitButton);
            tabPage1.Controls.Add(addBookBtn);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(bookStatusLabel);
            tabPage1.Controls.Add(bookIdLabel);
            tabPage1.Controls.Add(bookGenreLabel);
            tabPage1.Controls.Add(bookTitleLabel);
            tabPage1.Controls.Add(bookAuthorLabel);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1209, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(788, 558);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(993, 550);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(157, 48);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(38, 550);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(157, 48);
            addBookBtn.TabIndex = 6;
            addBookBtn.Text = "Add";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(exitBtn);
            tabPage2.Controls.Add(removeMemberBtn);
            tabPage2.Controls.Add(memberPhoneLabel);
            tabPage2.Controls.Add(memberLastNameLabel);
            tabPage2.Controls.Add(memberFirstNameLabel);
            tabPage2.Controls.Add(memberIdLabel);
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Controls.Add(addMemberBtn);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1209, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Members";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addMemberBtn
            // 
            addMemberBtn.Location = new Point(41, 545);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(151, 49);
            addMemberBtn.TabIndex = 0;
            addMemberBtn.Text = "Add";
            addMemberBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.217391F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.78261F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 378F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 367F));
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1210, 454);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // memberIdLabel
            // 
            memberIdLabel.AutoSize = true;
            memberIdLabel.Location = new Point(11, 7);
            memberIdLabel.Name = "memberIdLabel";
            memberIdLabel.Size = new Size(28, 25);
            memberIdLabel.TabIndex = 2;
            memberIdLabel.Text = "Id";
            // 
            // memberFirstNameLabel
            // 
            memberFirstNameLabel.AutoSize = true;
            memberFirstNameLabel.Location = new Point(188, 7);
            memberFirstNameLabel.Name = "memberFirstNameLabel";
            memberFirstNameLabel.Size = new Size(97, 25);
            memberFirstNameLabel.TabIndex = 3;
            memberFirstNameLabel.Text = "First Name";
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Location = new Point(611, 7);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(95, 25);
            memberLastNameLabel.TabIndex = 4;
            memberLastNameLabel.Text = "Last Name";
            // 
            // memberPhoneLabel
            // 
            memberPhoneLabel.AutoSize = true;
            memberPhoneLabel.Location = new Point(988, 7);
            memberPhoneLabel.Name = "memberPhoneLabel";
            memberPhoneLabel.Size = new Size(132, 25);
            memberPhoneLabel.TabIndex = 5;
            memberPhoneLabel.Text = "Phone Number";
            // 
            // removeMemberBtn
            // 
            removeMemberBtn.Location = new Point(243, 545);
            removeMemberBtn.Name = "removeMemberBtn";
            removeMemberBtn.Size = new Size(151, 49);
            removeMemberBtn.TabIndex = 6;
            removeMemberBtn.Text = "Remove";
            removeMemberBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(1029, 545);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(151, 46);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // removeBookBtn
            // 
            removeBookBtn.Location = new Point(248, 550);
            removeBookBtn.Name = "removeBookBtn";
            removeBookBtn.Size = new Size(157, 48);
            removeBookBtn.TabIndex = 9;
            removeBookBtn.Text = "Remove";
            removeBookBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1213, 673);
            Controls.Add(tabControl);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Library Manager";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label bookIdLabel;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookGenreLabel;
        private Label bookStatusLabel;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button exitButton;
        private Button addBookBtn;
        private Label label1;
        private Button addMemberBtn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label memberFirstNameLabel;
        private Label memberIdLabel;
        private Button removeMemberBtn;
        private Label memberPhoneLabel;
        private Label memberLastNameLabel;
        private Button removeBookBtn;
        private Button exitBtn;
    }
}
