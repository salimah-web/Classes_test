using System;
using System.Collections.Generic;
using System.Text;
using asp;
using Classes_test;
using System.Linq;

namespace Classes_test
{
    class BankOp: Introduction
    {
        public decimal Amount;
        public List<Validation> Database = new List<Validation>();
        public BankOp(List<Validation> database)
        {

            this.Database = database;
        }

        public override void Welcome()
        {
            Console.WriteLine("You are welcome to bank operations");//This method is overriden from abstract base class Introduction which explains polymorphism
        }
        public void deposit(int acc,decimal amount, List<Validation> database)
        {
            this.Amount = amount;
            var check = database.Where(i => i.account_no == acc ).FirstOrDefault();
            check.balance += Amount;
            Console.WriteLine("\nYour Deposit was successful, your account balance is {0}", check.balance);

            
        }
        public void withdrawal(int acc, decimal amount, List<Validation> database)
        {
            var check = database.Where(i => i.account_no == acc).FirstOrDefault();
            this.Amount = amount;
            if (Amount > check.balance)
            {
                Console.WriteLine("Insuffiecinet funds");
            }
            else
            {
                check.balance -= Amount;
                Console.WriteLine("\nYour withdrawal was successful, your account balance is {0}", check.balance);
            }
        }
        public void check_balance(int acc, List<Validation> database)
        {
            var check = database.Where(i => i.account_no == acc).FirstOrDefault();
            Console.WriteLine("\nYour withdrawal was successful, your account balance is {0}", check.balance);
        }
        public override void Thank_you()
        {
            Console.WriteLine("Thank you for carrying out banking operations here");
        }
    }
}
