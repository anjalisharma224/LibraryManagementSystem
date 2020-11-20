namespace LibraryManagementSystem
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.authorNameTextbox = new System.Windows.Forms.TextBox();
            this.publisherNameTextbox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.updateBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.availableBookLists = new System.Windows.Forms.DataGridView();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.noOfCopiesTextbox = new System.Windows.Forms.TextBox();
            this.logindbDataSet = new LibraryManagementSystem.logindbDataSet();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTblTableAdapter = new LibraryManagementSystem.logindbDataSetTableAdapters.BookTblTableAdapter();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofcopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.availableBookLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre:";
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Location = new System.Drawing.Point(163, 69);
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(227, 22);
            this.bookNameTextbox.TabIndex = 4;
            // 
            // authorNameTextbox
            // 
            this.authorNameTextbox.Location = new System.Drawing.Point(163, 108);
            this.authorNameTextbox.Name = "authorNameTextbox";
            this.authorNameTextbox.Size = new System.Drawing.Size(227, 22);
            this.authorNameTextbox.TabIndex = 5;
            // 
            // publisherNameTextbox
            // 
            this.publisherNameTextbox.Location = new System.Drawing.Point(163, 142);
            this.publisherNameTextbox.Name = "publisherNameTextbox";
            this.publisherNameTextbox.Size = new System.Drawing.Size(227, 22);
            this.publisherNameTextbox.TabIndex = 6;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Fiction",
            "Non Fiction"});
            this.genreComboBox.Location = new System.Drawing.Point(163, 178);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(227, 24);
            this.genreComboBox.TabIndex = 7;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(51, 269);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 46);
            this.addBookButton.TabIndex = 8;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // updateBookButton
            // 
            this.updateBookButton.Location = new System.Drawing.Point(184, 269);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(75, 46);
            this.updateBookButton.TabIndex = 9;
            this.updateBookButton.Text = "Update Book";
            this.updateBookButton.UseVisualStyleBackColor = true;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(315, 269);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(75, 46);
            this.deleteBookButton.TabIndex = 10;
            this.deleteBookButton.Text = "Delete Book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            // 
            // availableBookLists
            // 
            this.availableBookLists.AutoGenerateColumns = false;
            this.availableBookLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBookLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.publisherNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.noofcopiesDataGridViewTextBoxColumn});
            this.availableBookLists.DataSource = this.bookTblBindingSource;
            this.availableBookLists.Location = new System.Drawing.Point(12, 374);
            this.availableBookLists.Name = "availableBookLists";
            this.availableBookLists.RowHeadersWidth = 51;
            this.availableBookLists.RowTemplate.Height = 24;
            this.availableBookLists.Size = new System.Drawing.Size(437, 150);
            this.availableBookLists.TabIndex = 11;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(48, 337);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(342, 17);
            this.messageLabel.TabIndex = 25;
            this.messageLabel.Text = "Label to display add update delete success message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "No. Of Copies:";
            // 
            // noOfCopiesTextbox
            // 
            this.noOfCopiesTextbox.Location = new System.Drawing.Point(163, 217);
            this.noOfCopiesTextbox.Name = "noOfCopiesTextbox";
            this.noOfCopiesTextbox.Size = new System.Drawing.Size(100, 22);
            this.noOfCopiesTextbox.TabIndex = 27;
            // 
            // logindbDataSet
            // 
            this.logindbDataSet.DataSetName = "logindbDataSet";
            this.logindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this.logindbDataSet;
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "Book_Id";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "Book_Id";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Author_Name";
            this.authorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "Publisher_Name";
            this.publisherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            this.publisherNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // noofcopiesDataGridViewTextBoxColumn
            // 
            this.noofcopiesDataGridViewTextBoxColumn.DataPropertyName = "No_of_copies";
            this.noofcopiesDataGridViewTextBoxColumn.HeaderText = "No_of_copies";
            this.noofcopiesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noofcopiesDataGridViewTextBoxColumn.Name = "noofcopiesDataGridViewTextBoxColumn";
            this.noofcopiesDataGridViewTextBoxColumn.Width = 125;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 546);
            this.Controls.Add(this.noOfCopiesTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.availableBookLists);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.publisherNameTextbox);
            this.Controls.Add(this.authorNameTextbox);
            this.Controls.Add(this.bookNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableBookLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logindbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.TextBox authorNameTextbox;
        private System.Windows.Forms.TextBox publisherNameTextbox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button updateBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.DataGridView availableBookLists;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noOfCopiesTextbox;
        private logindbDataSet logindbDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private logindbDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofcopiesDataGridViewTextBoxColumn;
    }
}