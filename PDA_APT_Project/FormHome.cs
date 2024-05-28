using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using PDA_APT_Project.Entities;
using PDA_APT_Project.Repositories;


namespace PDA_APT_Project
{
    public partial class FormHome : Form
    {
        private TableManager tableManager;
        private DataInserter dataInserter;

        private SqlConnection _connection;
        private BookRepository BookRepository;
        private CustomerRepository CustomerRepository;

        ContextMenuStrip booksMenu = new ContextMenuStrip();

        public FormHome()
        {
            InitializeComponent();
            _connection = new SqlConnection(BaseRepository.DSN);
            _connection.Open();
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Connection failed");
                return;
            }
            label1.Text = _connection.State.ToString();

            BookRepository = new BookRepository(_connection);
            CustomerRepository = new CustomerRepository(_connection);

            tableManager = new TableManager(_connection);
            dataInserter = new DataInserter(_connection);
        }

        void createDatabase()
        {
            tableManager.CreateBooksTable();
            tableManager.CreateCustomersTable();
            tableManager.CreateOrdersTable();
            //tableManager.CreateDeliveriesTable();
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
            dataInserter.InsertBooksData();
            dataInserter.InsertCustomersData();
            dataInserter.InsertOrdersData();
            //dataInserter.InsertDeliveriesData();

        }

        private void DeleteBooks_Click(object sender, EventArgs e)
        {
            BookRepository.DeleteAll();
        }

        private void books_Click(object sender, EventArgs e)
        {
            // -- menu start

            // Initialize context menu strip
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();

            // Add menu items
            toolStripMenuItem1.Text = "Edit";
            toolStripMenuItem1.Click += onEditBookCellClick;

            toolStripMenuItem2.Text = "Delete";
            toolStripMenuItem2.Click += onDeleteBookCellClick;

            booksMenu.Items.Clear();
            booksMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });

            // -- menu end

            dataGridView1.ContextMenuStrip = booksMenu;

            dataGridView1.AutoGenerateColumns = true;
            List<Book> list = BookRepository.SelectAll();

            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        private void onEditBookCellClick(object sender, EventArgs e)
        {
            // Implement edit functionality here
            MessageBox.Show(((ToolStripMenuItem)sender).Tag.ToString());
        }

        private void onDeleteBookCellClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Assuming the book ID is stored in the first cell of the row
                int bookId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Now you have the book ID, you can use it in your delete method
                // For example:
                BookRepository.Delete(bookId);
                // Where DeleteBook is a method that deletes the book from the database
                MessageBox.Show("Book with ID " + bookId + " has been deleted.");
                dataGridView1.DataSource = BookRepository.SelectAll();
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Right)
            {
                // Select the row that was clicked
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Show the context menu at the clicked location
                booksMenu.Show(dataGridView1, e.Location);
            }
        }

        private void customers_Click(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = null;

            dataGridView1.AutoGenerateColumns = true;
            List<Customer> list = CustomerRepository.SelectAll();

            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        private void insertBook_Click(object sender, EventArgs e)
        {
            FormInsertBook formInsertBook = new FormInsertBook(BookRepository);

            formInsertBook.ShowDialog();
        }
    }
}
