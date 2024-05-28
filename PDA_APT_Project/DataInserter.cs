using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PDA_APT_Project
{
    public class DataInserter
    {
        private SqlConnection connection;

        public DataInserter(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void InsertBooksData()
        {
            var books = new List<(string BookName, string Author, string Price, int PageNumber)>
            {
                ("A Caribbean Mystery", "Agatha Christie", "10$", 288),
                ("The Shining", "Stephen King", "15$", 447),
                ("1984", "George Orwell", "12$", 328),
                ("To Kill a Mockingbird", "Harper Lee", "13$", 281),
                ("The Catcher in the Rye", "J.D. Salinger", "9$", 277),
                ("Pride and Prejudice", "Jane Austen", "11$", 279),
                ("The Great Gatsby", "F. Scott Fitzgerald", "10$", 218),
                ("Lord of the Flies", "William Golding", "8$", 224),
                ("The Hobbit", "J.R.R. Tolkien", "14$", 310),
                ("Moby-Dick", "Herman Melville", "13$", 624),
                ("War and Peace", "Leo Tolstoy", "17$", 1225)
            };

            foreach (var book in books)
            {
                string insertCommandText = "INSERT INTO Books (BookName, Author, Price, PageNumber) VALUES (@BookName, @Author, @Price, @PageNumber)";

                using (SqlCommand cmd = new SqlCommand(insertCommandText, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@BookName", book.BookName);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@Price", book.Price);
                    cmd.Parameters.AddWithValue("@PageNumber", book.PageNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertCustomersData()
        {
            var customers = new List<(string Name, string Email, string Phone)>
            {
                ("John Doe", "john.doe@example.com", "123-456-7890"),
                ("Alice Smith", "alice.smith@example.com", "987-654-3210")
            };

            foreach (var customer in customers)
            {
                string insertCommandText = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";

                using (SqlCommand cmd = new SqlCommand(insertCommandText, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Email", customer.Email);
                    cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void InsertOrderItemsData()
        {
            var orderItems = new List<(int OrderId, int BookId, int Quantity)>
            {
                (1, 1, 2),
                (1, 2, 1),
                (2, 3, 3),
                (2, 4, 1)
            };

            foreach (var orderItem in orderItems)
            {
                string insertCommandText = "INSERT INTO OrderItems (OrderId, BookId, Quantity) VALUES (@OrderId, @BookId, @Quantity)";

                using (SqlCommand cmd = new SqlCommand(insertCommandText, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@OrderId", orderItem.OrderId);
                    cmd.Parameters.AddWithValue("@BookId", orderItem.BookId);
                    cmd.Parameters.AddWithValue("@Quantity", orderItem.Quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }   


        public void InsertOrdersData()
        {
            var orders = new List<(int CustomerId, DateTime OrderDate)>
            {
                (1, DateTime.Now),
                (2, DateTime.Now.AddDays(-1))
            };

            foreach (var order in orders)
            {
                string insertCommandText = "INSERT INTO Orders (CustomerId, OrderDate) VALUES (@CustomerId, @OrderDate)";

                using (SqlCommand cmd = new SqlCommand(insertCommandText, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                    cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

       /* public void InsertDeliveriesData()
        {
            var deliveries = new List<(int OrderId, DateTime DeliveryDate, string Status)>
            {
                (1, DateTime.Now, "Delivered"),
                (2, DateTime.Now.AddDays(2), "In Transit")
            };

            foreach (var delivery in deliveries)
            {
                string insertCommandText = "INSERT INTO Delivery (OrderId, DeliveryDate, Status) VALUES (@OrderId, @DeliveryDate, @Status)";

                using (SqlCommand cmd = new SqlCommand(insertCommandText, connection))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@OrderId", delivery.OrderId);
                    cmd.Parameters.AddWithValue("@DeliveryDate", delivery.DeliveryDate);
                    cmd.Parameters.AddWithValue("@Status", delivery.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }*/
    }
}
