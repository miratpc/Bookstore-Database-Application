namespace PDA_APT_Project
{
    partial class FormInsertBook
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
            bookNameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            authorInput = new TextBox();
            priceInput = new TextBox();
            pageNumberInput = new TextBox();
            save = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // bookNameInput
            // 
            bookNameInput.Location = new Point(113, 20);
            bookNameInput.Name = "bookNameInput";
            bookNameInput.Size = new Size(100, 23);
            bookNameInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 94);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Page Number";
            // 
            // authorInput
            // 
            authorInput.Location = new Point(113, 56);
            authorInput.Name = "authorInput";
            authorInput.Size = new Size(100, 23);
            authorInput.TabIndex = 5;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(113, 91);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(100, 23);
            priceInput.TabIndex = 6;
            // 
            // pageNumberInput
            // 
            pageNumberInput.Location = new Point(113, 128);
            pageNumberInput.Name = "pageNumberInput";
            pageNumberInput.Size = new Size(100, 23);
            pageNumberInput.TabIndex = 7;
            // 
            // save
            // 
            save.Location = new Point(123, 168);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 8;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 233);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 9;
            // 
            // FormInsertBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 353);
            Controls.Add(comboBox1);
            Controls.Add(save);
            Controls.Add(pageNumberInput);
            Controls.Add(priceInput);
            Controls.Add(authorInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bookNameInput);
            Name = "FormInsertBook";
            Text = "FormInsertBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bookNameInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox authorInput;
        private TextBox priceInput;
        private TextBox pageNumberInput;
        private Button save;
        private ComboBox comboBox1;
    }
}