using PDA_APT_Project.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDA_APT_Project.Entities;

namespace PDA_APT_Project
{
    public partial class FormInsertBook : Form
    {
        public BookRepository BookRepository;

        public FormInsertBook(BookRepository bookRepository)
        {
            InitializeComponent();
            BookRepository = bookRepository;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (bookNameInput.Text == "")
            {
                MessageBox.Show("Book name cannot be empty");
                return;
            } else if (authorInput.Text == "")
            {
                MessageBox.Show("Author cannot be empty");
                return;
            } else if (priceInput.Text == "")
            {
                MessageBox.Show("Price cannot be empty");
                return;
            } else if (pageNumberInput.Text == "")
            {
                MessageBox.Show("Page number cannot be 0");
                return;
            }

            Book book = new Book
            {
                BookName = bookNameInput.Text,
                Author = authorInput.Text,
                Price = priceInput.Text,
                PageNumber = Convert.ToInt32(pageNumberInput.Text)
            };
            BookRepository.Insert(book);
            MessageBox.Show("Book added successfully");
            this.Close();

        }
    }
}
