// .NET
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMySQLApplication
{
    /* The ShowCustomersWindow contains 
        controls which show a list of all
        customers in the Database */
    public partial class ShowCustomersWindow : Form
    {
        // ****************
        // * CONSTURCTORS *
        // ****************
        
        // Constructor
        public ShowCustomersWindow() {
            this.InitializeComponent();
        }
        
        // ***********
        // * GENERAL *
        // ***********

        /* Refresh clears the Database Table Control
            and populates it with fresh data from
            the database */
        public void refresh() {
            // Clear the window conttrols
            this.clear();
            // Grab an instance of the Database Wrapper
            DatabaseWrapper databaseWrapper = DatabaseWrapper.getInstance();
            // Grab the list of Customers from the database
            List<Customer> customers = databaseWrapper.getCustomers();
            // Go through each customer one at a time
            foreach(Customer customer in customers) {
                // Grab CustomerID
                String customerID = customer.CustomerID.ToString();
                // Grab CustomerTitle
                String customerTitle = customer.Title;
                // Grab CustomerGivenNames
                String customerGivenNames = customer.GivenNames;
                // Grab CustomerLastNames
                String customerLastNames = customer.LastName;
                // Add a new row to the DatabaseTableControl
                this.DatabaseTableControl.Rows.Add(customerID, customerTitle, customerGivenNames, customerLastNames);
            }
        }
        // Clears this window of data
        public void clear() {
            // Clear all the Rows in the DatabaseTableControl
            this.DatabaseTableControl.Rows.Clear();
        }

        // **********
        // * EVENTS *
        // **********

        // Window loads
        private void ShowCustomersWindow_Load(object sender, EventArgs e) {
            // Clear the GUI
            this.clear();
            // Refresh the Controls on load
            this.refresh();
        }
    }
}
