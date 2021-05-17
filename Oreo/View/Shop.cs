using System;
using Oreo.Controller;
using Oreo.Model;

namespace Oreo.View
{
    class Shop
    {
        enum Options
        {
            Default = 0,
            Add = 1,
            Remove = 2,
            Cart = 3,
            Finish = 4,
            Exit = 5
        }
        public static void LaunchShopMenu(string user)
        {
            bool start = true;
            int option = (int)Options.Default;

            do
            {
                ShowMenu(user);
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Alert.ShowAlert("Invalid Option", ConsoleColor.Red);
                }
                switch (option)
                {
                    case (int)Options.Add:
                        Banner.ShowBanner("Add to Shopping Cart");
                        ProductCtrl.ReadAllProducts();
                        ShopCtrl.GetProduct(Product.GetId().Id, user);
                        Alert.Confirmation();
                        break;
                    case (int)Options.Remove:
                        Banner.ShowBanner("Remove from Shopping Cart");
                        ShopCtrl.ShowShoppingCart();
                        ShopCtrl.RemoveProduct(Product.GetId().Id);
                        Alert.Confirmation();
                        break;
                    case (int)Options.Cart:
                        Banner.ShowBanner("          Your Shopping Cart          ");
                        ShopCtrl.ShowShoppingCart();
                        Alert.Confirmation();
                        break;
                    case (int)Options.Finish:
                        Banner.ShowBanner("          Your Order is Finished          ");
                        UtilityMenu.LaunchFinishMenu(user);
                        Alert.Confirmation();
                        break;
                    case (int)Options.Exit:
                        start = false;
                        break;
                }
            } while (start);
        }

        public static void ShowMenu(string user)
        {
            Console.Clear();
            Console.Write("\n");
            Alert.ShowMessage($"========================================================================", ConsoleColor.DarkBlue);
            Alert.ShowMessage($"                              Shop                    |  UserID: " + user + "  |", ConsoleColor.DarkMagenta);
            Console.Write("\n");
            Alert.ShowAlert("(1) Add Product (2) Remove Product (3) Shopping Cart (4) Finish (5) Back", ConsoleColor.DarkBlue);
            Console.Write("\n");
            Console.Write("\n\tWhat you want to do? ");
        }
    }
}
