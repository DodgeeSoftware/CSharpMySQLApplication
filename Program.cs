// .NET
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpMySQLApplication
{
    // Contains the Entry Point for our program
    class Program
    {
        // Program Entry Point
        static void Main(string[] args)
        {
            // Grab the Database Wrapper
            DatabaseWrapper databaseWrapper = DatabaseWrapper.getInstance();
            // Connect to the Data
            if (databaseWrapper.connect("localhost", "admin", "admin") == false) {
                // Send a message to the console
                System.Console.WriteLine("Failed to Connect to the Database");
                // We cannot continue without a database connection
                return;
            }
            // Instantiate and Run the Application
            Application.EnableVisualStyles();
            Application.Run(new MainWindow());
            // Disconnect from the Database
            databaseWrapper.disconnect();
        }
    }
}