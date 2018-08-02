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
    /* Find Customer Window gives the user
        a GUI with which to search for a Customer */
    public partial class FindCustomerWindow : Form
    {
        // ****************
        // * CONSTRUCTORS *
        // ****************
        
        // Constructor
        public FindCustomerWindow() {
            this.InitializeComponent();
        }

        // ***********
        // * WINDOWS *
        // ***********
        
        // Customer Window
        CustomerWindow customerWindow = null;

        // ***********
        // * GENERAL *
        // ***********

        // Validate Form
        public bool isFormValid() {
            // TextBox Must contain data
            if (this.IDTextBox.Text.Length == 0) {
                // Invalid
                return false;
            }
            // Go through each letter
            foreach (char c in this.IDTextBox.Text) {
                // If the letter isn't a number
                if (!Char.IsNumber(c)) {
                    // Invalid
                    return false;
                }
            }
            // Valid 
            return true;                
        }
        // Clear the Window Contents
        public void clear() {
            // Clear the ID TextBox
            this.IDTextBox.Text = "";
        }

        // **********
        // * EVENTS *
        // **********

        // User clicked Ok Button
        private void OkButton_Click(object sender, EventArgs e) {
            if (this.isFormValid() == true) {
                // Grab the Database Instance
                DatabaseWrapper databaseWrapper = DatabaseWrapper.getInstance();
                // Grab the CustomerID
                long customerID = Convert.ToInt64(this.IDTextBox.Text);
                // If there is a customer with the ID
                if (databaseWrapper.isCustomer(customerID) == true) {
                    // Grab Customer
                    Customer customer = databaseWrapper.getCustomer(customerID);
                    // Make a New Customer Window
                    this.customerWindow = new CustomerWindow();
                    // Set the Customer for our New Window
                    this.customerWindow.setCustomer(customer);
                    // Clear the Window
                    this.clear();
                    // Show dialog for our new Window
                    this.customerWindow.ShowDialog();
                    return;
                }
                else {
                    // Message to the user
                    MessageBox.Show("ERROR: No Customer found with that Record");
                    // Return due to error
                    return;
                }
            }
            else {
                // Return due to error
                return;
            }
        }

        // User clicked  Button
        private void CancelButton_Click(object sender, EventArgs e) {
            // Clear the Window
            this.clear();
            // Close the Window
            this.Close();
        }

        // Form Loads
        private void FindCustomerWindow_Load(object sender, EventArgs e)
        {
            //Clear the GUI
            this.clear();
        }
    }
}
