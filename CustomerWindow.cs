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
    /* The CustomerWindow contains all the
        Controls for a User to view a customer
        record */
    public partial class CustomerWindow : Form
    {
        // ****************
        // * CONSTRUCTORS *
        // ****************

        // Constructor
        public CustomerWindow() {
            this.InitializeComponent();
        }

        // ***********
        // * GENERAL *
        // ***********

        // Refresh the GUI based on the customer
        public void refresh() {
            // Validate the Customer
            if (customer == null) {
                return;
            }
            // Set the CustomerID TextBox to the CustomerID
            this.IDTextBox.Text = customer.CustomerID.ToString();
            // Set the TitleTextBox to the CustomerTitle
            this.TitleTextBox.Text = customer.Title.ToString();
            // Set the GivenNamesTextBox to the CustomerGivenNames
            this.GivenNamesTextBox.Text = customer.GivenNames.ToString();
            // Set the LastNameTextBox to the CustomerLastName
            this.LastNameTextBox.Text = customer.LastName.ToString();
        }
        // Clear the Window Contents
        public void clear() {
            // Clear the IDTextBox
            this.IDTextBox.Text = "";
            // Clear Title TexBox
            this.TitleTextBox.Text = "";
            // Clear Given Names TextBox
            this.GivenNamesTextBox.Text = "";
            // Clear Last Name TexBox
            this.LastNameTextBox.Text = "";
        }
        // Set Customer
        public void setCustomer(Customer customer)  {
            this.customer = customer;
        }
        
        // Customer
        protected Customer customer = null;

        // **********
        // * EVENTS *
        // **********

        // User Clicked Done
        private void DoneButton_Click(object sender, EventArgs e) {
            // Clear the Window
            this.clear();
            // Close the Window
            this.Close();
        }

        // Form Loads
        private void CustomerWindow_Load(object sender, EventArgs e)
        {
            // Clear the GUI
            this.clear();
            // Refersh the GUI to reflect the Customer
            this.refresh();
        }
    }
}
