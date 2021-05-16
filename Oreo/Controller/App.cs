﻿using System;
using System.Collections.Generic;
using System.Text;
using Oreo.Model;
using Oreo.Controller;
using Oreo.View;

namespace Oreo.Controller
{
    class App
    {
        public static void InitializeApp()
        {
            int start = 1;
            do
            {               
                char opt = '0';
                Console.Clear();
                Alert.Welcome();
                Banner.ShowMainMenu();
                opt = char.Parse(Console.ReadLine());
                switch (opt)
                {
                    case '1':
                        ProductMenu.LaunchProductMenu();
                        break;
                    case '2':
                        EmployeeMenu.LaunchEmployeeMenu();
                        break;
                    case '3':
                        LaunchShopMenu();
                        break;
                    case '4':
                        //LaunchPrintMenu();
                        break;
                    case '5':
                        start = 0;
                        Alert.Bye();
                        break;
                }
            } while (start ==1);      
        }

        public static void LaunchShopMenu()
        {
            Console.Clear();
            ProductCtrl.ReadAllProducts();
            Console.Write("\n");
            Console.Write("\n\tEnter Product ID: ");
            int opt = char.Parse(Console.ReadLine());

        }

    }
}