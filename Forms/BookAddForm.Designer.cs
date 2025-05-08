namespace LibraryManager.Forms
{
    partial class BookAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bookTitleText = new TextBox();
            bookAuthorText = new TextBox();
            bookGenreText = new TextBox();
            bookTitleLabel = new Label();
            bookAuthorLabel = new Label();
            bookGenreLabel = new Label();
            addBookBtn = new Button();
            cancelAddBtn = new Button();
            bookAddErrorLabel = new Label();
            SuspendLayout();
            // 
            // bookTitleText
            // 
            bookTitleText.Location = new Point(129, 71);
            bookTitleText.Name = "bookTitleText";
            bookTitleText.Size = new Size(315, 31);
            bookTitleText.TabIndex = 0;
            // 
            // bookAuthorText
            // 
            bookAuthorText.Location = new Point(129, 187);
            bookAuthorText.Name = "bookAuthorText";
            bookAuthorText.Size = new Size(315, 31);
            bookAuthorText.TabIndex = 1;
            // 
            // bookGenreText
            // 
            bookGenreText.Location = new Point(129, 303);
            bookGenreText.Name = "bookGenreText";
            bookGenreText.Size = new Size(315, 31);
            bookGenreText.TabIndex = 2;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new Font("Segoe UI", 12F);
            bookTitleLabel.Location = new Point(21, 71);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new Size(60, 32);
            bookTitleLabel.TabIndex = 3;
            bookTitleLabel.Text = "Title";
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new Font("Segoe UI", 12F);
            bookAuthorLabel.Location = new Point(21, 184);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new Size(87, 32);
            bookAuthorLabel.TabIndex = 4;
            bookAuthorLabel.Text = "Author";
            // 
            // bookGenreLabel
            // 
            bookGenreLabel.AutoSize = true;
            bookGenreLabel.Font = new Font("Segoe UI", 12F);
            bookGenreLabel.Location = new Point(21, 303);
            bookGenreLabel.Name = "bookGenreLabel";
            bookGenreLabel.Size = new Size(78, 32);
            bookGenreLabel.TabIndex = 5;
            bookGenreLabel.Text = "Genre";
            
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(69, 445);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(134, 53);
            addBookBtn.TabIndex = 6;
            addBookBtn.Text = "Add";
            addBookBtn.UseVisualStyleBackColor = true;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // cancelAddBtn
            // 
            cancelAddBtn.Location = new Point(269, 445);
            cancelAddBtn.Name = "cancelAddBtn";
            cancelAddBtn.Size = new Size(134, 53);
            cancelAddBtn.TabIndex = 7;
            cancelAddBtn.Text = "Cancel";
            cancelAddBtn.UseVisualStyleBackColor = true;
            cancelAddBtn.Click += cancelAddBtn_Click;
            // 
            // bookAddErrorLabel
            // 
            bookAddErrorLabel.AutoSize = true;
            bookAddErrorLabel.ForeColor = Color.Red;
            bookAddErrorLabel.Location = new Point(156, 376);
            bookAddErrorLabel.Name = "bookAddErrorLabel";
            bookAddErrorLabel.Size = new Size(0, 25);
            bookAddErrorLabel.TabIndex = 8;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 566);
            Controls.Add(bookAddErrorLabel);
            Controls.Add(cancelAddBtn);
            Controls.Add(addBookBtn);
            Controls.Add(bookGenreLabel);
            Controls.Add(bookAuthorLabel);
            Controls.Add(bookTitleLabel);
            Controls.Add(bookGenreText);
            Controls.Add(bookAuthorText);
            Controls.Add(bookTitleText);
            Name = "BookAddForm";
            Text = "Form2";
            Load += BookAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookTitleText;
        private TextBox bookAuthorText;
        private TextBox bookGenreText;
        private Label bookTitleLabel;
        private Label bookAuthorLabel;
        private Label bookGenreLabel;
        private Button addBookBtn;
        private Button cancelAddBtn;
        private Label bookAddErrorLabel;
    }
}