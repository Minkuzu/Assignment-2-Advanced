using A2CL;
using A2CL.Furnitures;
using A2CL.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A2CA
{
    public class Program
    {
        public static List<Room> rooms = new List<Room>();
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
        int qty;
        Room kitchen = new Kitchen();
        Room kitsug = new Kitchen();
        public void DecorKitchen()
        {
            Console.WriteLine("You choose to decorate the Kitchen.");
            Console.WriteLine("Choose a color you wanted: ");
            kitchen.Color = Console.ReadLine();
            Console.WriteLine("Choose a style you wanted: ");
            kitchen.Style = Console.ReadLine();
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your kitchen to be(m2): ");
                        kitchen.Area = double.Parse(Console.ReadLine());
                        if (kitchen.Area < 0 || kitchen.Area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (kitchen.Area < 0 || kitchen.Area > 40);
                    kitchen = new Kitchen(kitchen.Color, kitchen.Style, kitchen.Area);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your kitchen ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                kitchen = new Chair(kitchen);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 chairs in the kichen");
                        }
                    } while (qty < 0 || qty > 4);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your kitchen ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 3)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                kitchen = new Door(kitchen);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the kichen");
                        }
                    } while (qty < 0 || qty > 3);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your kitchen ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 2)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                kitchen = new Fan(kitchen);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 2 fans in the kichen");
                        }
                    } while (qty < 0 || qty > 2);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your kitchen ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                kitchen = new Table(kitchen);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 tables in the kichen");
                        }
                    } while (qty < 0 || qty > 4);
                }
                catch (Exception)
                {
                    kitchen.Area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (kitchen.Area < 0 || kitchen.Area > 40);
            Console.WriteLine(kitchen.Visualize());
        }
        Room livingroom = new Livingroom();
        Room livsug = new Livingroom();
        public void DecorLivingroom()
        {
            Console.WriteLine("You choose to decorate the Livingroom.");
            Console.WriteLine("Choose a color you wanted: ");
            livingroom.Color = Console.ReadLine();
            Console.WriteLine("Choose a style you wanted: ");
            livingroom.Style = Console.ReadLine();
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your livingroom to be(m2): ");
                        livingroom.Area = double.Parse(Console.ReadLine());
                        if (livingroom.Area < 0 || livingroom.Area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (livingroom.Area < 0 || livingroom.Area > 40);
                    livingroom = new Kitchen(livingroom.Color, livingroom.Style, livingroom.Area);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your livingroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 8)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                livingroom = new Chair(livingroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 8 chairs in the livingroom");
                        }
                    } while (qty < 0 || qty > 8);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your livingroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                livingroom = new Door(livingroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 doors in the livingroom");
                        }
                    } while (qty < 0 || qty > 4);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your livingroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 3)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                livingroom = new Fan(livingroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 3 fans in the livingroom");
                        }
                    } while (qty < 0 || qty > 3);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your livingroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                livingroom = new Table(livingroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 tabls in the livingroom");
                        }
                    } while (qty < 0 || qty > 4);
                }
                catch (Exception)
                {
                    livingroom.Area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (livingroom.Area < 0 || livingroom.Area > 40);
        }
        Room bathroom = new Bathroom();
        Room batsug = new Bathroom();
        public void DecorBathroom()
        {
            Console.WriteLine("You choose to decorate the Bathroom.");
            Console.WriteLine("Choose a color you wanted: ");
            bathroom.Color = Console.ReadLine();
            Console.WriteLine("Choose a style you wanted: ");
            bathroom.Style = Console.ReadLine();
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your bathroom to be(m2): ");
                        bathroom.Area = double.Parse(Console.ReadLine());
                        if (bathroom.Area < 0 || bathroom.Area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (bathroom.Area < 0 || bathroom.Area > 40);
                    bathroom = new Bathroom(bathroom.Color, bathroom.Style, bathroom.Area);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your bathroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 2)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bathroom = new Chair(bathroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 2 chairs in the bathroom");
                        }
                    } while (qty < 0 || qty > 2);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your bathroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 || qty <= 3)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bathroom = new Door(bathroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the bathroom");
                        }
                    } while (qty < 0 || qty > 3);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your bathroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 1)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bathroom = new Fan(bathroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 1 fans in the bathroom");
                        }
                    } while (qty < 0 || qty > 1);
                    do
                    {
                        Console.WriteLine("How many bathtubs you wanted in your bathroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 2)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bathroom = new Bathtub(bathroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 2 bathtubs in the bathroom");
                        }
                    } while (qty < 0 || qty > 2);
                }
                catch (Exception)
                {
                    bathroom.Area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (bathroom.Area < 0 || bathroom.Area > 40);
        }
        Room bedroom = new Bedroom();
        Room bedsug = new Bedroom();
        public void DecorBedroom()
        {
            Console.WriteLine("You choose to decorate the Bedroom.");
            Console.WriteLine("Choose a color you wanted: ");
            bedroom.Color = Console.ReadLine();
            Console.WriteLine("Choose a style you wanted: ");
            bedroom.Style = Console.ReadLine();
            do
            {
                try
                {
                    do
                    {
                        Console.WriteLine("How big do you want your bedroom to be(m2): ");
                        bedroom.Area = double.Parse(Console.ReadLine());
                        if (bedroom.Area < 0 || bedroom.Area > 40)
                        {
                            Console.WriteLine("Our company only support to 40m2");
                        }
                    } while (bedroom.Area < 0 || bedroom.Area > 40);
                    bedroom = new Bedroom(bedroom.Color, bedroom.Style, bedroom.Area);
                    do
                    {
                        Console.WriteLine("How many chairs you wanted in your bedroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bedroom = new Chair(bedroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 chairs in the bedroom");
                        }
                    } while (qty < 0 || qty > 4);
                    do
                    {
                        Console.WriteLine("How many doors you wanted in your bedroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 3)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bedroom = new Door(bedroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 3 doors in the bedroom");
                        }
                    } while (qty < 0 || qty > 3);
                    do
                    {
                        Console.WriteLine("How many fans you wanted in your bedroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 2)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bedroom = new Fan(bedroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 2 fans in the bedroom");
                        }
                    } while (qty < 0 || qty > 2);
                    do
                    {
                        Console.WriteLine("How many tables you wanted in your bedroom ? : ");
                        qty = int.Parse(Console.ReadLine());
                        if (qty >= 0 && qty <= 4)
                        {
                            for (int i = 0; i < qty; i++)
                            {
                                bedroom = new Table(bedroom);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can only add max up to 4 tables in the bedroom");
                        }
                    } while (qty < 0 || qty > 4);
                }
                catch (Exception)
                {
                    bedroom.Area = -1;
                    Console.WriteLine("Invalid input");
                }
            } while (bedroom.Area < 0 || bedroom.Area > 40);
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
                    for (int k = 0; k < 4; k++)
                    {
                        kitsug = new Chair(kitsug);
                    }
                    kitsug = new Door(kitsug);
                    kitsug = new Fan(kitsug);
                    kitsug = new Table(kitsug);
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
                    Room livsug = new Livingroom("Brown", "Retro", 18.00);
                    for (int k = 0; k < 8; k++)
                    {
                        livsug = new Chair(livsug);
                    }
                    for (int k = 0; k < 4; k++)
                    {
                        livsug = new Door(livsug);
                    }
                    for (int k = 0; k < 2; k++)
                    {
                        livsug = new Fan(livsug);
                    }
                    for (int k = 0; k < 2; k++)
                    {
                        livsug = new Table(livsug);
                    }
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
                    batsug = new Bathtub(batsug);
                    batsug = new Door(batsug);
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
                    bedsug = new Table(bedsug);
                    bedsug = new Fan(bedsug);
                    h = bedsug.Visualize();
                    i = bedsug.TotalCost();
                }
                else if (suggestion == "n" || suggestion == "N")
                {
                    h = bedroom.Visualize();
                    i = bedroom.TotalCost();
                    Console.WriteLine(bedroom.Visualize());
                    Console.WriteLine("The bedrooom with your design cost: " + bedroom.TotalCost() + ".000.000vnd");
                }
                else
                {
                    Console.WriteLine("Please enter y/n");
                }
            } while (suggestion != "y" && suggestion != "Y" && suggestion != "N" && suggestion != "n");
            Console.WriteLine("" + a);
            Console.WriteLine("The kitchen cost: " + b + ".000.000vnd");
            Console.WriteLine("" + c);
            Console.WriteLine("The livingroom cost: " + d + ".000.000vnd");
            Console.WriteLine("" + f);
            Console.WriteLine("The bathroom cost: " + g + ".000.000vnd");
            Console.WriteLine("" + h);
            Console.WriteLine("The bedroom cost: " + i + ".000.000vnd");
        }
    }
}



