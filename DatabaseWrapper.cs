// .Net
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MYSQL
using MySql;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.EntityFrameworkCore;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace CSharpMySQLApplication {
    /* The DatabaseWrapper is a singleton wrapper 
        which provides a simple interface for 
        common interactions with the database */
    class DatabaseWrapper {

        // ****************
        // * CONSTRUCTORS *
        // ****************

        // Private Constructor
        protected DatabaseWrapper() { }

        // *************
        // * SINGLETON *
        // *************

        // Get instance of the Singleton
        public static DatabaseWrapper getInstance() {
            // If we have no instance
            if (DatabaseWrapper.instance == null) {
                // Create an instance
                DatabaseWrapper.instance = new DatabaseWrapper();
            }
            // return the instance
            return DatabaseWrapper.instance;
        }

        // Database Instance
        protected static DatabaseWrapper instance = null;

        // ***********************
        // * DATABASE CONNECTION *
        // ***********************

        // Connect to the Database
        public bool connect(String url, String username, String password) {
            // Connection String
            String connectionString = "server=" + url + ";user=" + username + ";database=dbtest;port=3306;password=" + password + ";";
            System.Console.WriteLine("Connect to Database");
            // Create the Connection
            this.connection = new MySqlConnection(connectionString);
            if (this.connection == null) {
                // Failure
                return false;
            }
            // Try and Open the Connection
            try {
                this.connection.Open();
            }
            catch (Exception e) {
                // Send a message to the COnsole
                Console.WriteLine("Error: " + e.ToString());
                // Failure
                return false;
            }

            // Success
            return true;
        }
        // Disconnect from the Database
        public void disconnect() {
            System.Console.WriteLine("Disconnect from Database");
            // Close Connection
            this.connection.Close();
        }

        // Database Connection
        protected MySqlConnection connection = null;

        // **********************
        // * DATABASE FUNCTIONS *
        // **********************

        // Add a Customer to the Database
        public bool addCustomer(String title, string givenNames, string lastName) {
            // Validate Connection
            if (this.connection == null) {
                return false;
            }
            // Validate Parameters
            if (title.Length == 0 || givenNames.Length == 0 || lastName.Length == 0) {
                return true;
            }
            // Assemble the Insert Statement
            String sql = "INSERT INTO Customers(Title, GivenNames, LastName) ";
            sql += "VALUES(\'" + title + "\', '" + givenNames + "\', '" + lastName + "\')";
            System.Console.WriteLine(sql);
            // Create and execute the SQL command
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            /* Result here is the number of rows our sql statement changed*/
            int result = command.ExecuteNonQuery();
            // If we changed exactly one row then
            if (result != 1) {
                // Return failure
                return false;
            }
            // Succes
            return true;
        }
        // Is Customer
        public bool isCustomer(long customerID) {
            // Validate Connection
            if (this.connection == null) {
                return false;
            }
            // Validate Customer ID
            if (customerID < 0) {
                return false;
            }
            // Build the SQL statement
            string sql = "SELECT CustomerID FROM Customers WHERE CustomerID=" + customerID.ToString();
            System.Console.WriteLine(sql);
            // Create and execute the SQL command
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader result = command.ExecuteReader();
            // Find out how many rows there are 
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Load(result);
            result.Close();
            if (dataTable.Rows.Count == 1) {
                // We found a customer with the ID provided
                return true;
            }
            // We did not find a customer with the ID provided
            return false;
        }
        // Get Customer
        public Customer getCustomer(long customerID) {
            // Make a new Customer
            Customer customer = new Customer();
            // Validate Connection
            if (this.connection == null) {
                return customer;
            }
            // Validate Customer ID
            if (customerID < 0) {
                return customer;
            }
            // Build the SQL statement
            string sql = "SELECT * FROM Customers WHERE CustomerID=" + customerID.ToString();
            System.Console.WriteLine(sql);
            // Create and execute the SQL command
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader result = command.ExecuteReader();
            // Find out how many rows there are 
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable.Load(result);
            result.Close();
            if (dataTable.Rows.Count == 1)
            {
                /* We found a customer with the ID provided 
                    populate our Customer Object with the data
                    extracted from the Database */
                System.Data.DataRow row = dataTable.Rows[0];
                customer.CustomerID = Convert.ToInt64(row["CustomerID"]);
                customer.Title = row["Title"].ToString();
                customer.GivenNames = (String)row["GivenNames"];
                customer.LastName = (String)row["LastName"];
            }
            // Return the Customer
            return customer;
        }
        // Remove customer
        public void removeCustomer(long customerID) {
            // Validate Connection
            if (this.connection == null) {
                return;
            }
            // Validate Customer ID
            if (customerID < 0) {
                return;
            }
            // Build the SQL statement
            string sql = "DELETE FROM Customers WHERE CustomerID=" + customerID.ToString();
            System.Console.WriteLine(sql);
            // Create and execute the SQL command
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            command.ExecuteNonQuery();
        }
        // Grab a list of all the Customers
        public List<Customer> getCustomers() {
            // Validate Connection
            if (this.connection == null) {
                return new List<Customer>();
            }
            // Create our list of Customers
            List<Customer> customers = new List<Customer>();
            // Build the SQL statement
            string sql = "SELECT * FROM Customers";
            System.Console.WriteLine(sql);
            // Create and execute the SQL command
            MySqlCommand command = new MySqlCommand(sql, this.connection);
            MySqlDataReader result = command.ExecuteReader();
            while (result.Read()) {
                // Create a new Customer
                Customer customer = new Customer();
                customer.CustomerID = Convert.ToInt64(result["CustomerID"]);
                customer.Title = (String)result["Title"];
                customer.GivenNames = (String)result["GivenNames"];
                customer.LastName = (String)result["LastName"];
                // Add our new Customer to our list of Customers
                customers.Add(customer);
            }
            result.Close();
            // return out list of Customers
            return customers;
        }
    }
}
