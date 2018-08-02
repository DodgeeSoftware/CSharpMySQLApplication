using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMySQLApplication
{
    /* The Customer Class contains basic 
        data about a customer */
    public class Customer
    {
        // **************
        // * PROPERTIES *
        // **************

        // Customer ID
        public long CustomerID
        { get; set; }
        // Title
        public string Title
        { get; set; }
        // GivenNames
        public string GivenNames
        { get; set; }
        // LastName
        public string LastName
        { get; set; }
    }
}
