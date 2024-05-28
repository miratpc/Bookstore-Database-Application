namespace PDA_APT_Project
{
    partial class FormHome
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
            InsertData = new Button();
            books = new Button();
            label1 = new Label();
            Delete_Books = new Button();
            dataGridView1 = new DataGridView();
            customers = new Button();
            insertBook = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InsertData
            // 
            InsertData.BackColor = Color.Yellow;
            InsertData.Location = new Point(36, 51);
            InsertData.Name = "InsertData";
            InsertData.Size = new Size(182, 40);
            InsertData.TabIndex = 2;
            InsertData.Text = "Insert Default Data";
            InsertData.UseVisualStyleBackColor = false;
            InsertData.Click += InsertData_Click;
            // 
            // books
            // 
            books.Location = new Point(36, 153);
            books.Name = "books";
            books.Size = new Size(182, 50);
            books.TabIndex = 3;
            books.Text = "Books";
            books.UseVisualStyleBackColor = true;
            books.Click += books_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // Delete_Books
            // 
            Delete_Books.Location = new Point(36, 97);
            Delete_Books.Name = "Delete_Books";
            Delete_Books.Size = new Size(182, 50);
            Delete_Books.TabIndex = 6;
            Delete_Books.Text = "DeleteBooks";
            Delete_Books.UseVisualStyleBackColor = true;
            Delete_Books.Click += DeleteBooks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(883, 323);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // customers
            // 
            customers.Location = new Point(36, 209);
            customers.Name = "customers";
            customers.Size = new Size(182, 50);
            customers.TabIndex = 9;
            customers.Text = "Customers";
            customers.UseVisualStyleBackColor = true;
            customers.Click += customers_Click;
            // 
            // insertBook
            // 
            insertBook.Location = new Point(36, 310);
            insertBook.Name = "insertBook";
            insertBook.Size = new Size(182, 50);
            insertBook.TabIndex = 10;
            insertBook.Text = "Insert Book";
            insertBook.UseVisualStyleBackColor = true;
            insertBook.Click += insertBook_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 657);
            Controls.Add(insertBook);
            Controls.Add(customers);
            Controls.Add(dataGridView1);
            Controls.Add(Delete_Books);
            Controls.Add(label1);
            Controls.Add(books);
            Controls.Add(InsertData);
            Name = "FormHome";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button InsertData;
        private Button books;
        private Label label1;
        private Button Delete_Books;
        private DataGridView dataGridView1;
        private Button customers;
        private Button insertBook;
    }
}
