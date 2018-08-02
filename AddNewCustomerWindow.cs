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
    /* The Add New Customer Window creates
        a GUI Panel which the user interacts with
        to add customers to the database */
    public partial class AddNewCustomerWindow : Form
    {
        // ****************
        // * CONSTRUCTORS *
        // ****************

        // Constructor
        public AddNewCustomerWindow() {
            this.InitializeComponent();
        }

        // ***********
        // * GENERAL *
        // ***********

        // Clear the window Contents
        public void clear() {
            // Select the First Index
            this.TitleComboBox.SelectedIndex = 0;
            // Clear Given Names TextBox
            this.GivenNamesTextBox.Text = "";
            // Clear Last Names TextBox
            this.LastNameTextBox.Text = "";
        }

        // **********
        // * EVENTS *
        // **********

        // The User Clicks Ok
        private void OkButton_Click(object sender, EventArgs e)
        {
            // Grab the Instance of our Database Wrapper
            DatabaseWrapper databaseWrapper = DatabaseWrapper.getInstance();
            String customerTitle = this.TitleComboBox.Text;
            String givenNames = this.GivenNamesTextBox.Text;
            String lastName = this.LastNameTextBox.Text;
            // Try and Add the Customer to the Databaase
            if (databaseWrapper.addCustomer(customerTitle, givenNames, lastName) == false) {
                // Show a MessageBox
                MessageBox.Show("Error: Unable to add customer: " + customerTitle + " " + givenNames + " " + lastName);
            }
            else {
                // Show a MessageBox
                MessageBox.Show("Success! Added customer: " + customerTitle + " " + givenNames + " " + lastName);
            }
            // Clear the Window
            this.clear();
            // Close the Window
            this.Close();
        }
        
        // The User Clicks Cancel
        private void CancelButton_Click(object sender, EventArgs e) {
            // Clear the Window
            this.clear();
            // Close the Window
            this.Close();
        }
        
        // On Window Load
        private void AddNewCustomerWindow_Load(object sender, EventArgs e)
        {
            // Set the Default Selected Index
            this.TitleComboBox.SelectedIndex = 0;
        }
    }
}
