using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();
            string choice;
            do
            {
                Console.WriteLine("Choose from one of the options below\n1.Add a Book\n2.View All Books\n3.Search By BookID\n4.Search by Title\n5.Exit");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            lib.AddBook();
                        }
                        break;
                    case 2:
                        {
                            lib.ViewAllBooks();
                        }
                        break;
                    case 3:
                        {
                            lib.SearchBookByID();
                        }
                        break;
                    case 4:
                        {
                            lib.SearchBookByTitle();
                        }
                        break;
                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong option");
                        }
                        break;
                }
                Console.WriteLine("Please press M to go back to the Main Menu");
                choice = Console.ReadLine().ToLower();
            } while (choice == "m");
            Console.ReadKey();
        }

    }
}
