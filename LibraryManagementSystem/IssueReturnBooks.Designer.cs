namespace LibraryManagementSystem
{
    partial class IssueReturnBooks
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
            this.components = new System.ComponentModel.Container();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.issueBookButton = new System.Windows.Forms.Button();
            this.loanHistoryGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(123, 69);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.userNameTextBox.TabIndex = 21;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(123, 41);
            this.userIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.userIDTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "User\'s Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "User ID:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(408, 44);
            this.bookIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.bookIDTextBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Book ID:";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(408, 71);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.ReadOnly = true;
            this.bookNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.bookNameTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Book Name:";
            // 
            // returnBookButton
            // 
            this.returnBookButton.Location = new System.Drawing.Point(329, 114);
            this.returnBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(60, 44);
            this.returnBookButton.TabIndex = 27;
            this.returnBookButton.Text = "Return Book";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // issueBookButton
            // 
            this.issueBookButton.Location = new System.Drawing.Point(237, 114);
            this.issueBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.issueBookButton.Name = "issueBookButton";
            this.issueBookButton.Size = new System.Drawing.Size(56, 44);
            this.issueBookButton.TabIndex = 26;
            this.issueBookButton.Text = "Issue Book";
            this.issueBookButton.UseVisualStyleBackColor = true;
            this.issueBookButton.Click += new System.EventHandler(this.issueBookButton_Click);
            // 
            // loanHistoryGridView
            // 
            this.loanHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanHistoryGridView.Location = new System.Drawing.Point(123, 172);
            this.loanHistoryGridView.Margin = new System.Windows.Forms.Padding(2);
            this.loanHistoryGridView.Name = "loanHistoryGridView";
            this.loanHistoryGridView.RowHeadersWidth = 51;
            this.loanHistoryGridView.RowTemplate.Height = 24;
            this.loanHistoryGridView.Size = new System.Drawing.Size(439, 168);
            this.loanHistoryGridView.TabIndex = 28;
            
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IssueReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.loanHistoryGridView);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.issueBookButton);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IssueReturnBooks";
            this.Text = "IssueReturnBooks";
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnBookButton;
        private System.Windows.Forms.Button issueBookButton;
        private System.Windows.Forms.DataGridView loanHistoryGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}