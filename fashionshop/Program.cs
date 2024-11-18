using fashionshop.View;
using fashionshop.Model.Product;
using fashionshop.Controller;

namespace fashionshop

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //MessageBox.Show(example.Description);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Login());
            //Application.Run(new RegisterProduct());
            //Application.Run(new ProductsRegistered());
            Application.Run(new PointOfSale());



        }
    }
}