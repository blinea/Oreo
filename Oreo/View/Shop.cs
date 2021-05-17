using System;
using System.Collections.Generic;
using System.Text;
using Oreo.View;
using Oreo.Controller;
using Oreo.Model;

namespace Oreo.View
{
    class Shop
    {
        public static void LaunchShopMenu(string user)
        {
            
            

            int start = 1;
            char option = '0';

            do
            {

                ShowMenu(user);

                try
                {
                    option = char.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Invalid Option", ConsoleColor.Red);
                }
                switch (option)
                {
                    case '1':
                        Banner.ShowBanner("Add to Shopping Cart");
                        ProductCtrl.ReadAllProducts();
                        ShopCtrl.GetProduct(Product.GetId().Id, user);
                        Alert.Confirmation();
                        break;
                    case '2':
                        Banner.ShowBanner("Remove from Shopping Cart");
                        ShopCtrl.ShowShoppingCart();
                        ShopCtrl.RemoveProduct(Product.GetId().Id);
                        Alert.Confirmation();
                        break;
                    case '3':
                        Banner.ShowBanner("          Your Shopping Cart          ");
                        ShopCtrl.ShowShoppingCart();
                        Alert.Confirmation();
                        break;
                    case '4':
                        start = 0;
                        break;
                    case '5':
                        start = 0;
                        break;
                }
            } while (start == 1);
        }

        public static void ShowMenu(string user)
        {
            Console.Clear();
            Console.Write("\n");
            Alert.ShowMessage($"==========================================================================", ConsoleColor.DarkBlue);
            Alert.ShowMessage($"                              Shop                    |  UserID: " + user + "  |", ConsoleColor.DarkMagenta);
            Console.Write("\n");
            Alert.ShowAlert("(1) Add Product (2) Remove Product (3) Shopping Cart (4) Finish (5) Back", ConsoleColor.DarkBlue);
            Console.Write("\n");
            Console.Write("\n\tWhat you want to do? ");
        }

    }
}
