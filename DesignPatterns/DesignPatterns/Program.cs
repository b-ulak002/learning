#define COI //use keyworks here to test the patterns.
using DesignPatterns.Adapter;
using DesignPatterns.CompositionOverInheritance;
using DesignPatterns.Observer;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
#if singleton
            //Singleton Pattern
            Player p1 = Player.Instance;
            Console.WriteLine($"Name = {p1.Name}, Lvl = {p1.Level}");
#endif

#if factory
            //Factory Pattern
            Gameboard gb = new Gameboard();
            gb.PlayArea(1);
#endif

#if strategy
            //Strategy Pattern
            ShoppingCart cart1 = new ShoppingCart(new TenPercentDiscountStrategy());
            cart1.CustomerName = "John Doe";
            cart1.BillAmount = 100;
            Console.WriteLine($"Customer = {cart1.CustomerName}, Bal = ${cart1.GetFinalBill()}");

            ShoppingCart cart2 = new ShoppingCart(new FiftyPercentDiscountStrategy());
            cart2.CustomerName = "Jack Wilson";
            cart2.BillAmount = 200;
            Console.WriteLine($"Customer = {cart2.CustomerName}, Bal = ${cart2.GetFinalBill()}");
#endif

#if chainofresponsibility
            //Chain of responsibility
            Material material = new Material
            {
                MaterialID = Guid.NewGuid(),
                Name = "Pebbles",
                PartNumber = "234",
                DrawingNumber = "345",
                Budget = 100000
            };

            Approver engineer = new EngineeringApprover();
            Approver purchasing = new PurchasingApprover();
            Approver finance = new FinanceApprover();

            engineer.SetNextApprover(purchasing);
            purchasing.SetNextApprover(finance);

            string reason = "";
            if(engineer.ApproveMaterial(material, ref reason))
            {
                Console.WriteLine($"Approved. {reason}");
            }
            else
            {
                Console.WriteLine($"Disapproved. Reason: {reason}");
            }
#endif

#if observer
            Amazon amzn = new Amazon(1752.12);
            Investor joe = new Investor("Joe");
            joe.BuyStock(amzn);          

            amzn.PriceChanged(1800.12);



#endif

#if adapter
            CustomerDTO customerDTO = new CustomerDTO
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                City = "Portland",
                State = "OR",
                PostalCode = "12345"
            };

            ICustomerList customerList = new CustomerAdapter();
            customerList.AddCustomer(customerDTO);

            List<Customer> c = customerList.GetCustomers();           
#endif

#if COI


#endif
            //Do not delete
            Console.ReadKey();

        }

        
    }
}
