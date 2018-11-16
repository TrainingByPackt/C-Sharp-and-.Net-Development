using System;

namespace ProductSDK
{
    /// <summary>
    /// 1. What - abstraction
    /// 2. How
    /// 3. Made complicated methods private - encapsualtion
    /// </summary>
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }

        public void Submit()
        {
            // Add to database.
            Validate();
            ConnectToDB();
        }

        // Granular method
        private bool Validate()
        {
            // ProductID & ProductName
            return true;
        }

        private bool ConnectToDB()
        {
            // DB Connect, SQL 
            return true;
        }


    }
}
