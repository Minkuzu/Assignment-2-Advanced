using Assignment2;
using Assignment2.Ass2.ConcreteFurnitures;
using Assignment2.ConcreteFurnitures;
using Assignment2.ConcreteRooms;
using Assignment2.Ass2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DecoratorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anInstanceofProgram = new Program();
            int choice;
            do
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Please choose from 0 - 5 based on what you need");
                Console.WriteLine("1. Decorate the Kitchen");
                Console.WriteLine("2. Decorate the Livingroom");
                Console.WriteLine("3. Decorate the Bathroom");
                Console.WriteLine("4. Decorate the Bedroom");
                Console.WriteLine("5. View your design and system suggestion");
                Console.WriteLine("0. Exit the program");
                try
                {
                    Console.Write("Please enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 0 || choice > 5)
                    {
                        Console.WriteLine("Your choice has to be a number from 0 - 5");
                    }
                    switch (choice)
                    {
                        case 1:
                            anInstanceofProgram.DecorKitchen();
                            break;
                        case 2:
                            anInstanceofProgram.DecorLivingroom();
                            break;
                        case 3:
                            anInstanceofProgram.DecorBathroom();
                            break;
                        case 4:
                            anInstanceofProgram.DecorBedroom();
                            break;
                        case 5:
                            anInstanceofProgram.Print();
                            break;
                        case 0:
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    choice = -1;
                    Console.WriteLine("Invalid Input");
                }

            } while (choice != 0);

        }
        Room kitchen = new Kitchen();
        Room kitsug = new Kitchen();
        public void DecorKitchen()
        {
            String color;
            String style;
            Double area;
            int qty;
            do
            {
                Console.WriteLine("You choose to decorate the Kitchen");
                Console.WriteLine("Choose a color you wanted: ");
                color = Console.ReadLine();
                Console.WriteLine("Choose a style you wanted: ");
                style = Console.ReadLine();
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your kitchen to be(m2): ");
                        area = double.Parse(Console.ReadLine());
                        if (area < 0 || area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (area < 0 || area > 40);
                    kitchen = new Kitchen(color, style, area);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your kitchen ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 3)
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the kitchen");
                        }
                    }
                    while (qty < 0 || qty > 3);
                    kitchen = new Door(kitchen, qty);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your kitchen ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 tables in the kitchen");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    kitchen = new Table(kitchen, qty);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your kitchen ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 chairs in the kitchen");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    kitchen = new Chair(kitchen, qty);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your kitchen ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 2)
                        {
                            Console.WriteLine("You can only add max up to 2 fans in the kitchen");
                        }
                    }
                    while (qty < 0 || qty > 2);
                    kitchen = new Fan(kitchen, qty);
                    qty = 0;
                    kitchen = new Bathtub(kitchen, qty);
                    Console.WriteLine(kitchen.Visualize());
                    Console.WriteLine("The kitchen with your design cost: " + kitchen.TotalCost() + ".000.000vnd");
                }
                catch (Exception)
                {
                    area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (area < 0 || area > 40);
            kitsug = new Kitchen(color, style, area);

        }
        Room livingroom = new LivingRoom();
        Room livsug = new LivingRoom();
        public void DecorLivingroom()
        {
            String color;
            String style;
            Double area;
            int qty;
            do
            {
                Console.WriteLine("You choose to decorate the Livingroom");
                Console.WriteLine("Choose a color you wanted: ");
                color = Console.ReadLine();
                Console.WriteLine("Choose a style you wanted: ");
                style = Console.ReadLine();
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your livingroom to be(m2): ");
                        area = double.Parse(Console.ReadLine());
                        if (area < 0 || area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (area < 0 || area > 40);
                    livingroom = new LivingRoom(color, style, area);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your livingroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 doors in the living");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    livingroom = new Door(livingroom, qty);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your livingroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 tables in the livingroom");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    livingroom = new Table(livingroom, qty);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your livingroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 8)
                        {
                            Console.WriteLine("You can only add max up to 8 chairs in the livingroom");
                        }
                    }
                    while (qty < 0 || qty > 8);
                    livingroom = new Chair(livingroom, qty);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your livingroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 3)
                        {
                            Console.WriteLine("You can only add max up to 3 fans in the livingroom");
                        }
                    }
                    while (qty < 0 || qty > 3);
                    livingroom = new Fan(livingroom, qty);
                    qty = 0;
                    livingroom = new Bathtub(livingroom, qty);
                    Console.WriteLine(livingroom.Visualize());
                    Console.WriteLine("The livingroom with your design cost: " + livingroom.TotalCost() + ".000.000vnd");
                }
                catch (Exception)
                {
                    area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (area < 0 || area > 40);
            livsug = new LivingRoom(color, style, area);

        }
        Room bathroom = new Bathroom();
        Room batsug = new Bathroom();
        public void DecorBathroom()
        {
            String color;
            String style;
            Double area;
            int qty;
            do
            {
                Console.WriteLine("You choose to decorate the Bathroom");
                Console.WriteLine("Choose a color you wanted: ");
                color = Console.ReadLine();
                Console.WriteLine("Choose a style you wanted: ");
                style = Console.ReadLine();
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your bathroom to be(m2): ");
                        area = double.Parse(Console.ReadLine());
                        if (area < 0 || area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (area < 0 || area > 40);
                    bathroom = new Kitchen(color, style, area);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your bathroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 3)
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the bathroom");
                        }
                    }
                    while (qty < 0 || qty > 3);
                    bathroom = new Door(bathroom, qty);
                    qty = 0;
                    bathroom = new Table(bathroom, qty);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your bathroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 2)
                        {
                            Console.WriteLine("You can only add max up to 2 chairs in the bathroom");
                        }
                    }
                    while (qty < 0 || qty > 2);
                    bathroom = new Chair(bathroom, qty);
                    qty = 0;
                    bathroom = new Fan(bathroom, qty);
                    do
                    {
                        Console.WriteLine("How many bathtubs you wanted in your bathroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 2)
                        {
                            Console.WriteLine("You can only add max up to 2 bathtubs in the bathroom");
                        }
                    }
                    while (qty < 0 || qty > 2);
                    bathroom = new Bathtub(bathroom, qty);
                    Console.WriteLine(bathroom.Visualize());
                    Console.WriteLine("The bathroom with your design cost: " + bathroom.TotalCost() + ".000.000vnd");
                }
                catch (Exception)
                {
                    area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (area < 0 || area > 40);
            batsug = new Bathroom(color, style, area);

        }
        Room bedroom = new Bedroom();
        Room bedsug = new Bedroom();
        public void DecorBedroom()
        {
            String color;
            String style;
            Double area;
            int qty;
            do
            {
                Console.WriteLine("You choose to decorate the Bedroom");
                Console.WriteLine("Choose a color you wanted: ");
                color = Console.ReadLine();
                Console.WriteLine("Choose a style you wanted: ");
                style = Console.ReadLine();
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your bedroom to be(m2): ");
                        area = double.Parse(Console.ReadLine());
                        if (area < 0 || area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (area < 0 || area > 40);
                    bedroom = new Bedroom(color, style, area);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your bedroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 3)
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the bedroom");
                        }
                    }
                    while (qty < 0 || qty > 3);
                    bedroom = new Door(bedroom, qty);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your bedroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 tables in the bedroom");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    bedroom = new Table(bedroom, qty);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your bedroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 4)
                        {
                            Console.WriteLine("You can only add max up to 4 chairs in the bedroom");
                        }
                    }
                    while (qty < 0 || qty > 4);
                    bedroom = new Chair(bedroom, qty);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your bedroom ?");
                        qty = int.Parse(Console.ReadLine());
                        if (qty < 0 || qty > 2)
                        {
                            Console.WriteLine("You can only add max up to 2 fans in the bedroom");
                        }
                    }
                    while (qty < 0 || qty > 2);
                    bedroom = new Fan(bedroom, qty);
                    qty = 0;
                    bedroom = new Bathtub(bedroom, qty);
                    Console.WriteLine(bedroom.Visualize());
                    Console.WriteLine("The bedroom with your design cost: " + bedroom.TotalCost() + ".000.000vnd");
                }
                catch (Exception)
                {
                    area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (area < 0 || area > 40);
            bedsug = new Bedroom(color, style, area);

        }
        public void Print()
        {
            string a = "a";
            double b = 0.00;
            string c = "c";
            double d = 0.00;
            string f = "f";
            double g = 0.00;
            string h = "h";
            double i = 0.00;
            string suggestion;
            Console.WriteLine(kitchen.Visualize());
            Console.WriteLine("The kitchen with your desgin design cost: " + kitchen.TotalCost() + ".000.000vnd");
            Console.WriteLine(kitchen.Suggestion());
            do
            {
                suggestion = Console.ReadLine();
                if (suggestion == "y" || suggestion == "Y")
                {
                    Room kitsug = new Kitchen("Red", "Modern", 20.00);
                    kitsug = new Door(kitsug, 1);
                    kitsug = new Table(kitsug, 1);
                    kitsug = new Chair(kitsug, 4);
                    kitsug = new Fan(kitsug, 1);
                    kitsug = new Bathtub(kitsug, 0);
                    a = kitsug.Visualize();
                    b = kitsug.TotalCost();
                }
                else if (suggestion == "n" || suggestion == "N")
                {
                    a = kitchen.Visualize();
                    b = kitchen.TotalCost();
                    Console.WriteLine(kitchen.Visualize());
                    Console.WriteLine("The kitchen with your design cost: " + kitchen.TotalCost() + ".000.000vnd");
                }
                else
                {
                    Console.WriteLine("Please enter y/n");
                }
            } while (suggestion != "y" && suggestion != "Y" && suggestion != "N" && suggestion != "n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(livingroom.Visualize());
            Console.WriteLine("The livingroom with your design design cost: " + livingroom.TotalCost() + ".000.000vnd");
            Console.WriteLine(livingroom.Suggestion());
            do
            {
                suggestion = Console.ReadLine();
                if (suggestion == "y" || suggestion == "Y")
                {
                    Room livsug = new LivingRoom("Brown", "Retro", 18.00);
                    livsug = new Door(livsug, 4);
                    livsug = new Table(livsug, 2);
                    livsug = new Chair(livsug, 8);
                    livsug = new Fan(livsug, 2);
                    livsug = new Bathtub(livsug, 0);
                    c = livsug.Visualize();
                    d = livsug.TotalCost();
                }
                else if (suggestion == "n" || suggestion == "N")
                {
                    c = livingroom.Visualize();
                    d = livingroom.TotalCost();
                    Console.WriteLine(livingroom.Visualize());
                    Console.WriteLine("The livingroom with your design cost: " + livingroom.TotalCost() + ".000.000vnd");
                }
                else
                {
                    Console.WriteLine("Please enter y/n");
                }
            } while (suggestion != "y" && suggestion != "Y" && suggestion != "N" && suggestion != "n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(bathroom.Visualize());
            Console.WriteLine("The bathroom with your design design cost: " + bathroom.TotalCost() + ".000.000vnd");
            Console.WriteLine(bathroom.Suggestion());
            do
            {
                suggestion = Console.ReadLine();
                if (suggestion == "y" || suggestion == "Y")
                {
                    Room batsug = new Bathroom("White", "Clean", 16.00);
                    batsug = new Door(batsug, 1);
                    batsug = new Table(batsug, 0);
                    batsug = new Chair(batsug, 0);
                    batsug = new Fan(batsug, 0);
                    batsug = new Bathtub(batsug, 1);
                    f = batsug.Visualize();
                    g = batsug.TotalCost();
                }
                else if (suggestion == "n" || suggestion == "N")
                {
                    f = bathroom.Visualize();
                    g = bathroom.TotalCost();
                    Console.WriteLine(bathroom.Visualize());
                    Console.WriteLine("The bathroom with your design cost: " + bathroom.TotalCost() + ".000.000vnd");
                }
                else
                {
                    Console.WriteLine("Please enter y/n");
                }
            } while (suggestion != "y" && suggestion != "Y" && suggestion != "N" && suggestion != "n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(bedroom.Visualize());
            Console.WriteLine("The bedroom with your design design cost: " + bedroom.TotalCost() + ".000.000vnd");
            Console.WriteLine(bedroom.Suggestion());
            do
            {
                suggestion = Console.ReadLine();
                if (suggestion == "y" || suggestion == "Y")
                {
                    Room bedsug = new Bedroom("Light blue", "Serenity", 14.00);
                    bedsug = new Door(bedsug, 2);
                    bedsug = new Table(bedsug, 1);
                    bedsug = new Chair(bedsug, 2);
                    bedsug = new Fan(bedsug, 1);
                    bedsug = new Bathtub(bedsug, 0);
                    h = bedsug.Visualize();
                    i = bedsug.TotalCost();
                }
                else if (suggestion == "n" || suggestion == "N")
                {
                    h = bedroom.Visualize();
                    i = bedroom.TotalCost();
                    Console.WriteLine(bedroom.Visualize());
                    Console.WriteLine("The bedroom with your design cost: " + bedroom.TotalCost() + ".000.000vnd");
                }
                else
                {
                    Console.WriteLine("Please enter y/n");
                }
            } while (suggestion != "y" && suggestion != "Y" && suggestion != "N" && suggestion != "n");
            Console.WriteLine("" + a);
            Console.WriteLine("The kitchen cost: " + b + ".000.000vnd");
            Console.WriteLine("" + c);
            Console.WriteLine("The livingroom cost: " + d +".000.000vnd");
            Console.WriteLine("" + f);
            Console.WriteLine("The bathroom cost: " + g + ".000.000vnd");
            Console.WriteLine("" + h);
            Console.WriteLine("The bedroom cost: " + i + ".000.000vnd");


        }

    }
}
