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
            testBtn = new Button();
            exitButton = new Button();
            addBookBtn = new Button();
            tabPage2 = new TabPage();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1179, 482);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new Point(21, 3);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new Size(28, 25);
            bookIdLabel.TabIndex = 1;
            bookIdLabel.Text = "Id";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Segoe UI", 9F);
            bookTitleLabel.Location = new Point(287, 3);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(44, 25);
            bookTitleLabel.TabIndex = 2;
            bookTitleLabel.Text = "Title";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Location = new Point(717, 3);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(67, 25);
            bookAuthorLabel.TabIndex = 3;
            bookAuthorLabel.Text = "Author";
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Location = new Point(956, 3);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(58, 25);
            bookGenreLabel.TabIndex = 4;
            bookGenreLabel.Text = "Genre";
            // 
            // bookStatusLabel
            // 
            bookStatusLabel.AutoSize = true;
            bookStatusLabel.Location = new Point(1090, 3);
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
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(testBtn);
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
            // testBtn
            // 
            testBtn.Location = new Point(533, 550);
            testBtn.Name = "testBtn";
            testBtn.Size = new Size(139, 41);
            testBtn.TabIndex = 7;
            testBtn.Text = "Test";
            testBtn.UseVisualStyleBackColor = true;
            testBtn.Click += testBtn_Click;
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
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1209, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Members";
            tabPage2.UseVisualStyleBackColor = true;
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
        private Button testBtn;
        private Label label1;
    }
}
