using System;

namespace DemoAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSDK.Product myProduct = new ProductSDK.Product();
            myProduct.ProductID = "100";
            myProduct.ProductName = "Telsa";
            
            myProduct.Submit();

        }
    }
}
