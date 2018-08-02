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
    /* The Remove Customer Window Class
        contains window controls that allow
        the user to remove a Customer record
        from the Database*/
    public partial class RemoveCustomerWindow : Form
    {
        // ****************
        // * CONSTRUCTORS *
        // ****************
        
        // Constructor
        public RemoveCustomerWindow() {
            InitializeComponent();
        }

        // ***********
        // * GENERAL *
        // ***********

        // Validate Form
        public bool validateForm() {
            // Validate the ID TextBox Length
            if (this.IDTextBox.Text.Length == 0) {
                // Invalid
                return false;
            }
            // Go through each character in the IDTextBox
            foreach (char c in this.IDTextBox.Text) {
                if (Char.IsDigit(c) == false) {
                    // Invalid
                    return false;
                }
            }
            // Valid
            return true;
        }
        // Clear the Window Controls
        public void clear() {
            // Clear the ID TextBox
            this.IDTextBox.Text = "";
        }

        // **********
        // * EVENTS *
        // **********

        // User Clicked Ok Button
        private void OKButton_Click(object sender, EventArgs e) {
            // Validate the form
            if (this.validateForm() == true) {
                // Grab the CustomerID
                long customerID = Convert.ToInt64(this.IDTextBox.Text);
                // Grab the Database Wrapper Instance
                DatabaseWrapper databaseWrapper = DatabaseWrapper.getInstance();
                // Check to see if there is a customer
                if (databaseWrapper.isCustomer(customerID) == true) {
                    // Remove the Customer
                    databaseWrapper.removeCustomer(customerID);
                    // Popup Message to the User
                    MessageBox.Show("Customer Record removed from the database");
                }
                else
                {
                    // Popup Message to the User
                    MessageBox.Show("ERROR: No Customer Record to remove");
                    // Return due to Error
                    return;
                }
            }
            else {
                // Popup Message to the User
                MessageBox.Show("ERROR: Invalid ID");
                // Return due to Error
                return;
            }
            // Clear this Window
            this.clear();
            // Close this Window
            this.Close();
        }
        // User Clicked Cancel Button
        private void CancelButton_Click(object sender, EventArgs e) {
            // Clear this Window
            this.clear();
            // Close this Window
            this.Close();
        }
        
        // Window Loads
        private void RemoveCustomerWindow_Load(object sender, EventArgs e)
        {
             // Clear the GUI
            this.clear();
        }
    }
}
