﻿using hueta;
using System;
using System.Diagnostics;
using System.Security.Principal;


internal class Program
{
    public static void Main()
    {
        Console.Title = "debug menu";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("main menu:");
            Console.WriteLine("1. minecraft parser");
            Console.WriteLine("2. discord webhook");
            Console.WriteLine("3. task manager");
            Console.WriteLine("4. kdmapper");
            Console.WriteLine("0. exit");
            Console.Write("number: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Minecraft.ParseServer();
                    break;

                case "2":
                    Webhook.Menu();
                    break;
                
                case "3":
                    Taskmgr.Manager();
                    break;
                
                case "4":
                    kdmapper.startdriver();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}