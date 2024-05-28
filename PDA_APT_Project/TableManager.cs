using System;
using System.Data.SqlClient;

namespace PDA_APT_Project
{
    public class TableManager
    {
        private SqlConnection connection;

        public TableManager(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void CreateBooksTable()
        {
            string commandText = @"CREATE TABLE [dbo].[Books] 
            (
                [ID] INT NOT NULL PRIMARY KEY IDENTITY,
                [Title] NVARCHAR(50) NULL,
                [BookName] NVARCHAR(50) NULL,
                [Author] NVARCHAR(50) NULL,
                [Price] NVARCHAR(50) NULL,
                [PageNumber] INT NULL
                
            )";

            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateCustomersTable()
        {
            string commandText = @"CREATE TABLE [dbo].[Customers]
            (
                [ID] INT NOT NULL PRIMARY KEY IDENTITY,
                [Name] NVARCHAR(50) NULL,
                [Email] NVARCHAR(50) NULL,
                [Phone] NVARCHAR(20) NULL
            )";

            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateOrdersTable()
        {
            string commandText = @"CREATE TABLE [dbo].[Orders]
            (
                [ID] INT NOT NULL PRIMARY KEY IDENTITY,
                [CustomerId] INT NOT NULL,
                [OrderDate] DATETIME NULL,
                FOREIGN KEY (CustomerId) REFERENCES Customers(ID)
            )";

            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateOrderItemsTable()
        {
            string commandText = @"CREATE TABLE DB_1.dbo.[OrderItems]
            (
                [ID] INT NOT NULL PRIMARY KEY IDENTITY,
                [OrderId] INT NOT NULL,
                [BookId] INT NOT NULL,
                [Quantity] INT NOT NULL,
                FOREIGN KEY (OrderId) REFERENCES Orders(ID),
                FOREIGN KEY (BookId) REFERENCES Books(ID)
            )";

            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

  /*      public void CreateDeliveriesTable()
        {
            string commandText = @"CREATE TABLE [dbo].[Deliveries]
            (
                [ID] INT NOT NULL PRIMARY KEY IDENTITY,
                [OrderId] INT NOT NULL,
                [DeliveryDate] DATETIME NULL,
                [Status] NVARCHAR(50) NULL,
                FOREIGN KEY (OrderId) REFERENCES Orders(ID)
            )";

            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }*/
    }
}
