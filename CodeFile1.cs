using System;
using System.Collections.Generic;
using System.Linq;
using Classes_test;
namespace asp 
{
    class Validation: Introduction
    {
        public string Name;
        private string Pin;
        public string Pinn
        {
            get { return Pin; }
            set
            {
                if (value.Length > 4)
                { Pin = value; }
                
            }
         }
        public decimal balance;
        public int account_no;
        public List<Validation> Database = new List<Validation>();
        public bool IsLoggedin;
        public Validation(string name, int account_noo, string pin, List<Validation> database)
        {
            this.Name = name;
            Random no = new Random();

            this.account_no=account_noo;
            Pinn = pin;
            this.Database = database;
            this.balance = 0;
            IsLoggedin = false;
        }
        public override void Welcome()
        {
            Console.WriteLine("You are welcome to the bank operation section!");
        }
        public void login(int account_noo, string pin, List<Validation> database)
        {


            var check = database.Where(i => i.account_no == account_noo).FirstOrDefault();
            if (check != null && pin == check.Pin)
            {
                Console.WriteLine(check.account_no);
                IsLoggedin = true;
            }
            else if (check != null && pin != check.Pin)
            {
                Console.WriteLine("Invalid password");
                Console.WriteLine(check.account_no);
                IsLoggedin = false;
            }
            else
            {
                Console.WriteLine("Account does not exist");

                IsLoggedin = false;
            }

        }
        public override void Thank_you()
        {
            Console.WriteLine("Thank you for choosing us");
        }

    }
    

}