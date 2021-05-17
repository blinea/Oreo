using System;
using Oreo.Controller;
using Oreo.Model;


namespace Oreo.View
{
    class ProductMenu
    {
        enum Options
        {
            Default = 0,
            Create = 1,
            Search = 2,
            Catalog = 3,
            Update = 4,
            Delete = 5,
            Exit = 6
        }
        public static void LaunchProductMenu()
        {
            bool start = true;
            do
            {
                int option = (int)Options.Default;
                Banner.ShowBigBanner("Products");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Please type a valid Option", ConsoleColor.Red);
                    Alert.Confirmation();
                }
                switch (option)
                {
                    case (int)Options.Create:
                        try
                        {
                            Banner.ShowBanner("Create Product");
                            ProductCtrl.CreateProduct(Product.GetAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case (int)Options.Search:
                        try
                        {
                            Banner.ShowBanner("Search Product");
                            ProductCtrl.ReadProduct(Product.GetId().Id);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case (int)Options.Catalog:
                        try
                        {
                            Banner.ShowBanner("Product Database");
                            ProductCtrl.ReadAllProducts();
                            Alert.Confirmation();
                            break;
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case (int)Options.Update:
                        try
                        {
                            Banner.ShowBanner("Update Product");
                            ProductCtrl.UpdateProduct(Product.GetAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case (int)Options.Delete:
                        try
                        {
                            Banner.ShowBanner("Delete Product");
                            ProductCtrl.DeleteProduct(Product.GetId().Id);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.ShowAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case (int)Options.Exit:
                        start = false;
                        break;
                }
            } while (start);
        }
    }
}
