using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Controller;
using Oreo.Model;
using Oreo.View;

namespace Oreo.Controller
{
    class ProductMenu
    {
        public static void LaunchProductMenu()
        {
            int start = 1;
            do
            {
                char option = '0';
                Banner.ShowBigBanner("Products");
                option = char.Parse(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        try
                        {
                            Banner.ShowBanner("Create Product");
                            ProductCtrl.CreateProduct(Product.getAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '2':
                        try
                        {
                            Banner.ShowBanner("Search Product");
                            ProductCtrl.ReadProduct(Product.getId().Id);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '3':
                        try
                        {
                            Banner.ShowBanner("Product Database");
                            ProductCtrl.ReadAllProducts();
                            Alert.Confirmation();
                            break;

                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '4':
                        try
                        {
                            Banner.ShowBanner("Update Product");
                            ProductCtrl.UpdateProduct(Product.getAllInfo());
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '5':
                        try
                        {
                            Banner.ShowBanner("Delete Product");
                            ProductCtrl.DeleteProduct(Product.getId().Id);
                            Alert.Confirmation();
                        }
                        catch (ApplicationException error)
                        {
                            Alert.showAlert(error.Message, ConsoleColor.Red);
                            Alert.Confirmation();
                            App.InitializeApp();
                        }
                        break;
                    case '6':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }
    }
}
