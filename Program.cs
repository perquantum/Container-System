using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int SN = 101;
            int ID = 11;
            string userId = "admin";
            string userPass = "admin";

            IDictionary<string, string> container = new Dictionary<string, string>();
            container.Add("1", "ContainerOne");
            container.Add("2", "ContainerTwo");
            container.Add("3", "ContainerThree");
            container.Add("4", "ContainerFour");
            container.Add("5", "ContainerFive");

            Dictionary<int, Dictionary<string, string>> cart = new Dictionary<int, Dictionary<string, string>>();
       


            while (true)
            {
                Console.Write("Enter User ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter Password: ");
                string pass = Console.ReadLine();

                if (id == userId && pass == userPass)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Book Containers\n2. Old Transaction\n3. Logout");
                        int response = Convert.ToInt16(Console.ReadLine());
                        if (response == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("id - Name  ");
                            foreach (KeyValuePair<string, string> kvp in container)
                            {
                                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                            }
                            Console.WriteLine("Enter id of container you want to book: ");
                            string ansB = Console.ReadLine();
                            cart.Add(SN, new Dictionary<string, string> { { ansB, container[ansB] } });
                            Console.WriteLine($"You have successfully booked the {container[ansB]}");
                            SN++;
                            ID++;
                            Console.WriteLine();
                            Console.WriteLine("Press enter to proceed");
                            Console.ReadLine();
                        }
                        else if (response == 2)
                        {
                            Console.WriteLine("SN   |  id  |  Name       ");
                            foreach (KeyValuePair<int, Dictionary<string, string>> ele in cart)
                            {
                                foreach (KeyValuePair<string, string> innerDict in ele.Value)
                                {
                                    Console.WriteLine($"{ele.Key}  |  {innerDict.Key}  |  ${innerDict.Value}");
                                }
                            }
                            Console.WriteLine("Press Enter to proceed");
                            Console.ReadLine();
                        }
                        else if (response == 3)
                        {
                            Console.WriteLine("You have successfully logged out.");
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong id or password!");
                    Console.WriteLine("Press enter to proceed");
                    Console.ReadLine();
                }
            }
        }
    }
}