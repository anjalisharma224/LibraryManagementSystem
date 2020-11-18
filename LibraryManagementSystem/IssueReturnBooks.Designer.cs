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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.loanHistoryGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(227, 22);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "User\'s Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "User ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(544, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 22);
            this.textBox4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Book ID:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(544, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(227, 22);
            this.textBox3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Book Name:";
            // 
            // updateBookButton
            // 
            this.updateBookButton.Location = new System.Drawing.Point(439, 140);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(80, 54);
            this.updateBookButton.TabIndex = 27;
            this.updateBookButton.Text = "Return Book";
            this.updateBookButton.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(316, 140);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 54);
            this.addBookButton.TabIndex = 26;
            this.addBookButton.Text = "Issue Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // loanHistoryGridView
            // 
            this.loanHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanHistoryGridView.Location = new System.Drawing.Point(164, 212);
            this.loanHistoryGridView.Name = "loanHistoryGridView";
            this.loanHistoryGridView.RowHeadersWidth = 51;
            this.loanHistoryGridView.RowTemplate.Height = 24;
            this.loanHistoryGridView.Size = new System.Drawing.Size(585, 207);
            this.loanHistoryGridView.TabIndex = 28;
            // 
            // IssueReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loanHistoryGridView);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IssueReturnBooks";
            this.Text = "IssueReturnBooks";
            ((System.ComponentModel.ISupportInitialize)(this.loanHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.DataGridView loanHistoryGridView;
    }
}