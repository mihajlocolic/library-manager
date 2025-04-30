namespace LibraryManager.Forms
{
    partial class MemberAddForm
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
            cancelAddBtn = new Button();
            addBookBtn = new Button();
            memberPhoneLabel = new Label();
            memberLastNameLabel = new Label();
            memberFirstNameLabel = new Label();
            bookGenreText = new TextBox();
            bookAuthorText = new TextBox();
            bookTitleText = new TextBox();
            SuspendLayout();
            // 
            // cancelAddBtn
            // 
            cancelAddBtn.Location = new Point(320, 437);
            cancelAddBtn.Name = "cancelAddBtn";
            cancelAddBtn.Size = new Size(134, 53);
            cancelAddBtn.TabIndex = 15;
            cancelAddBtn.Text = "Cancel";
            cancelAddBtn.UseVisualStyleBackColor = true;
            // 
            // addBookBtn
            // 
            addBookBtn.Location = new Point(120, 437);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(134, 53);
            addBookBtn.TabIndex = 14;
            addBookBtn.Text = "Add";
            addBookBtn.UseVisualStyleBackColor = true;
            // 
            // memberPhoneLabel
            // 
            memberPhoneLabel.AutoSize = true;
            memberPhoneLabel.Font = new Font("Segoe UI", 12F);
            memberPhoneLabel.Location = new Point(30, 294);
            memberPhoneLabel.Name = "memberPhoneLabel";
            memberPhoneLabel.Size = new Size(177, 32);
            memberPhoneLabel.TabIndex = 13;
            memberPhoneLabel.Text = "Phone Number";
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Font = new Font("Segoe UI", 12F);
            memberLastNameLabel.Location = new Point(33, 176);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(126, 32);
            memberLastNameLabel.TabIndex = 12;
            memberLastNameLabel.Text = "Last Name";
            // 
            // memberFirstNameLabel
            // 
            memberFirstNameLabel.AutoSize = true;
            memberFirstNameLabel.Font = new Font("Segoe UI", 12F);
            memberFirstNameLabel.Location = new Point(30, 60);
            memberFirstNameLabel.Name = "memberFirstNameLabel";
            memberFirstNameLabel.Size = new Size(129, 32);
            memberFirstNameLabel.TabIndex = 11;
            memberFirstNameLabel.Text = "First Name";
            // 
            // bookGenreText
            // 
            bookGenreText.Location = new Point(180, 295);
            bookGenreText.Name = "bookGenreText";
            bookGenreText.Size = new Size(315, 31);
            bookGenreText.TabIndex = 10;
            // 
            // bookAuthorText
            // 
            bookAuthorText.Location = new Point(180, 179);
            bookAuthorText.Name = "bookAuthorText";
            bookAuthorText.Size = new Size(315, 31);
            bookAuthorText.TabIndex = 9;
            // 
            // bookTitleText
            // 
            bookTitleText.Location = new Point(180, 63);
            bookTitleText.Name = "bookTitleText";
            bookTitleText.Size = new Size(315, 31);
            bookTitleText.TabIndex = 8;
            // 
            // MemberAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 557);
            Controls.Add(cancelAddBtn);
            Controls.Add(addBookBtn);
            Controls.Add(memberPhoneLabel);
            Controls.Add(memberLastNameLabel);
            Controls.Add(memberFirstNameLabel);
            Controls.Add(bookGenreText);
            Controls.Add(bookAuthorText);
            Controls.Add(bookTitleText);
            Name = "MemberAddForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelAddBtn;
        private Button addBookBtn;
        private Label memberPhoneLabel;
        private Label memberLastNameLabel;
        private Label memberFirstNameLabel;
        private TextBox bookGenreText;
        private TextBox bookAuthorText;
        private TextBox bookTitleText;
    }
}