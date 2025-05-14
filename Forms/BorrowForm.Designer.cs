namespace LibraryManager.Forms
{
    partial class BorrowForm
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
            borrowersComboBox = new ComboBox();
            memberBorrowLabel = new Label();
            borrowConfirmBtn = new Button();
            cancelBorrowBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // borrowersComboBox
            // 
            borrowersComboBox.FormattingEnabled = true;
            borrowersComboBox.Location = new Point(116, 180);
            borrowersComboBox.Name = "borrowersComboBox";
            borrowersComboBox.Size = new Size(362, 33);
            borrowersComboBox.TabIndex = 0;
            borrowersComboBox.Text = "Select member";
            // 
            // memberBorrowLabel
            // 
            memberBorrowLabel.AutoSize = true;
            memberBorrowLabel.Font = new Font("Segoe UI", 12F);
            memberBorrowLabel.Location = new Point(152, 111);
            memberBorrowLabel.Name = "memberBorrowLabel";
            memberBorrowLabel.Size = new Size(296, 32);
            memberBorrowLabel.TabIndex = 1;
            memberBorrowLabel.Text = "Select borrowing member:";
            // 
            // borrowConfirmBtn
            // 
            borrowConfirmBtn.Location = new Point(69, 467);
            borrowConfirmBtn.Name = "borrowConfirmBtn";
            borrowConfirmBtn.Size = new Size(157, 59);
            borrowConfirmBtn.TabIndex = 2;
            borrowConfirmBtn.Text = "Confirm";
            borrowConfirmBtn.UseVisualStyleBackColor = true;
            borrowConfirmBtn.Click += borrowConfirmBtn_Click;
            // 
            // cancelBorrowBtn
            // 
            cancelBorrowBtn.Location = new Point(365, 467);
            cancelBorrowBtn.Name = "cancelBorrowBtn";
            cancelBorrowBtn.Size = new Size(157, 59);
            cancelBorrowBtn.TabIndex = 3;
            cancelBorrowBtn.Text = "Cancel";
            cancelBorrowBtn.UseVisualStyleBackColor = true;
            cancelBorrowBtn.Click += cancelBorrowBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(500, 175);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(87, 40);
            resetBtn.TabIndex = 4;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 589);
            Controls.Add(resetBtn);
            Controls.Add(cancelBorrowBtn);
            Controls.Add(borrowConfirmBtn);
            Controls.Add(memberBorrowLabel);
            Controls.Add(borrowersComboBox);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox borrowersComboBox;
        private Label memberBorrowLabel;
        private Button borrowConfirmBtn;
        private Button cancelBorrowBtn;
        private Button resetBtn;
    }
}