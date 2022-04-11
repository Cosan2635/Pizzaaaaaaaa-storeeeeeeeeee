using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaaaaaaaa_storeeeeeeeeee
{

    public class Store
    {

        public void Start()
        {
            Test();
        }

        public void Test()
        {
            Console.WriteLine("*----------------------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("|                                                     Big Mama Pizzaria                                                |");
            Console.WriteLine("*----------------------------------------------------------------------------------------------------------------------*");

            // Create new custom  er here - insert their values
            CustomerCatalog customerCat = new CustomerCatalog();
            Customer c1 = new Customer(1, "Muhammed Cosan", 42167725, "Gildbrovej 52, Ishøj");
            Customer c2 = new Customer(2, "Raffael Karlisto", 24121642, " Maglevej 29, Roskilde");
            Customer c3 = new Customer(3, "Haydar Abi", 41859434, " Malmös hjørner, Malmö");
            // created now
            customerCat.CreateCustomer(c1);
            customerCat.CreateCustomer(c2);
            customerCat.CreateCustomer(c3);
            // Read customer
            customerCat.ReadCustomer(1);
            customerCat.ReadCustomer(2);
            customerCat.ReadCustomer(3);
            // Create new pizzas, insert the values
            MenuCatalog menucat = new MenuCatalog();
            Pizza p1 = new Pizza(1, "New York", 72);
            Pizza p2 = new Pizza(2, "Brøndby Special", 75);
            Pizza p3 = new Pizza(3, "Københavner", 85);
            Pizza p4 = new Pizza(3, "Haydar Abi", 950);
            //Created now
            menucat.CreatePizza(p1);
            menucat.CreatePizza(p2);
            menucat.CreatePizza(p3);
            // 
            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");
            Console.WriteLine($"{c1} har bestilt 1 X {p1} ");
            Console.WriteLine($"{c2} har bestilt 1 X {p2}");
            Console.WriteLine($"{c3} har bestilt 1 X {p3}");
            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");

            Console.WriteLine("Reading Pizza and Customers seperately:");
            Console.WriteLine(menucat.ReadPizza(1));
            Console.WriteLine(menucat.ReadPizza(2));
            Console.WriteLine("");
            Console.WriteLine(customerCat.ReadCustomer(1));
            Console.WriteLine(customerCat.ReadCustomer(2));
            Console.WriteLine(customerCat.ReadCustomer(3));

            menucat.UpdatePizza(p4);
            Console.WriteLine(menucat.ReadPizza(3));

            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("Slet Pizzaen");


            menucat.DeletePizza(p1);
            try
            {
                Console.WriteLine(menucat.ReadPizza(1));
            }
            catch
            {
                Console.WriteLine("Pizza 1 got Deleted");
            }
            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");


            // customerCat.DeleteCustomer(c1);
            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");

            Console.WriteLine("                                          Print info Customer / Menu                                                   ");
          
            menucat.PrintMenu();
            Console.WriteLine("");  
            customerCat.PrintMenu();

            Console.WriteLine("*---------------------------------------------------------------------------------------------------------------------*");
            List<string> menuList = new List<string>();
            menuList.Add("Create Pizza");
            menuList.Add("Search");
            menuList.Add("Update");
            menuList.Add("Delete");
            menuList.Add("Display Menu");
            menuList.Add("exit");
            Console.WriteLine();

            int menuchoice = menucat.MenuChoice(menuList);

            //Pizza Searched = menucat.Search("Haydar Abi");
            //Pizza Searched1 = menucat.Search("Brøndby Special");

            //Console.WriteLine();
            //Console.WriteLine($"Du har valgt - {Searched.ID} , {Searched.Name}, { Searched.Price}");
            //Console.WriteLine();
            //Console.WriteLine($"Du har valgt {Searched1.ID} : {Searched1.Name} : {Searched1.Price}");

            //Customer searchedCustomer = customerCat.Search("Haydar Abi");
            //Customer searchedCustomer1 = customerCat.Search("Muhammed Cosan");
            //Console.WriteLine($"Du har valgt {searchedCustomer.ID} : {searchedCustomer.Name} : {searchedCustomer.Telefonnr} : {searchedCustomer.Adresse}");
            //Console.WriteLine($"Du har valgt : {searchedCustomer1.ID} : {searchedCustomer1.Name} : {searchedCustomer1.Telefonnr} : {searchedCustomer1.Adresse}");


        }
    }
}