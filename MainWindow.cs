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
    /* The MainWindow Class is the contrainer
        for the Dashboard of our application.
        It is the centre from which the
        user opens other windows to interact
        with the application */
    public partial class MainWindow : Form
    {
        // ***************
        // * CONSTRUCTOR *
        // ***************

        // Constructor
        public MainWindow() {
            this.InitializeComponent();
        }

        // ***********
        // * WINDOWS *
        // ***********

        // Add New Customer Window
        AddNewCustomerWindow addNewCustomerWindow = null;
        // Find Customer Window
        FindCustomerWindow findCustomerWindow = null;
        // Remove Customer Window
        RemoveCustomerWindow removeCustomerWindow = null;
        // ShowCustomersWindow
        ShowCustomersWindow showCustomersWindow = null;

        // **********
        // * EVENTS *
        // **********
        
        // User clicked About Button
        private void AboutButton_Click(object sender, EventArgs e) {
            // Show a Modal Popup Window
            MessageBox.Show("(c) Dodgee Software 2018");
        }
        // User clicked Quit Button
        private void QuitButton_Click(object sender, EventArgs e) {
            // Close this Window
            this.Close();
        }
        // User clicked AddCustomers Button
        private void AddCustomerButton_Click(object sender, EventArgs e) {
            // Create a new Window
            this.addNewCustomerWindow = new AddNewCustomerWindow();
            // Show the new window
            this.addNewCustomerWindow.ShowDialog();
        }
        // User clicked FindCustomer Button
        private void FindCustomerButton_Click(object sender, EventArgs e) {
            // Create a new Window
            this.findCustomerWindow = new FindCustomerWindow();
            // // Show the new window
            this.findCustomerWindow.ShowDialog();
        }
        // User clicked RemoveCustomer Button
        private void RemoveCustomerButton_Click(object sender, EventArgs e) {
            // Create a new Window
            this.removeCustomerWindow = new RemoveCustomerWindow();
            // Show the new window
            this.removeCustomerWindow.ShowDialog();
        }
        // User clicked ShowCustomers Button
        private void ShowCustomersButton_Click(object sender, EventArgs e) {
            this.showCustomersWindow = new ShowCustomersWindow();
            // Show the new window
            this.showCustomersWindow.ShowDialog();
        }        
        // Window Loads
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Do Nothing
        }
    }
}
