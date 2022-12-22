using A2CL;
using A2CL.Furnitures;
using A2CL.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2CA2
{
    internal class Program
    {
        public static List<Room> rooms = new List<Room>();
        static void Main(string[] args)
        {
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
                            Kitchen kitchen = new Kitchen();
                            Add(kitchen);
                            break;
                        case 2:
                            Livingroom livingroom = new Livingroom();
                            Add(livingroom);
                            break;
                        case 3:
                            Bathroom bathroom = new Bathroom();
                            Add(bathroom);
                            break;
                        case 4:
                            Bedroom bedroom = new Bedroom();
                            Add(bedroom);
                            break;
                        case 5:
                            Print(rooms);
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
        static void Print(List<Room> rooms)
        {
            List<Room> temproom = rooms.ToList();
            while(temproom.Count > 0)
            {
                Room room1 = temproom[0];
                Console.WriteLine(room1.Visualize() + 1 + room1.TotalCost());
            }
        }
        static void Add(Room room)
        {
            int max_qty = 0;
            int choice;
            do
            {
                Console.WriteLine("1. Bathtub");
                Console.WriteLine("2. Chair");
                Console.WriteLine("3. Door");
                Console.WriteLine("4. Fan");
                Console.WriteLine("5. Table");
                Console.WriteLine("0. Return");
                Console.Write("Select : ");
                do
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 0 || choice > 5)
                        {
                            Console.WriteLine("Enter a valid number");
                        }
                    }
                    catch (System.Exception)
                    {
                        choice = -1;
                        Console.WriteLine("Invalid number");
                    }


                } while (choice < 0 || choice > 6);
                switch(choice)
                {
                    case 1:
                        if(room.Name == "Kitchen")
                        {
                            max_qty = 0;
                        }else if(room.Name == "Livingroom")
                        {
                            max_qty = 0;
                        }else if(room.Name == "Bathroom")
                        {
                            max_qty = 2;
                        }else if(room.Name == "Bedroom")
                        {
                            max_qty = 0;
                        }
                        if(room.getQty() < max_qty)
                        {
                            room = new Bathtub(room, 1);
                            Console.WriteLine("You've added 1 bathtub");
                        }
                        else
                        {
                            Console.WriteLine("You cannot add more bathtub");
                        }

                        break;
                    case 2:
                        Console.WriteLine("You've added 1 chair");
                        room = new Chair(room);
                        break;
                    case 3:
                        Console.WriteLine("You've added 1 door");
                        room = new Door(room);
                        break;
                    case 4:
                        Console.WriteLine("You've added 1 fan");
                        room = new Fan(room);
                        break;
                    case 5:
                        Console.WriteLine("You've added 1 table");
                        room = new Table(room);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
            rooms.Add(room);
            Console.WriteLine(room.Visualize() + " " + room.TotalCost());
        }
    }
}
