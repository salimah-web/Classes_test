using System;
using System.Collections.Generic;
using asp;
using Classes_test;
using System.Linq;
namespace class11
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Validation> database = new List<Validation>();
            Validation example = new Validation("salima", 102345678, "12345", database);
            database.Add(example);

            bool isoption = false;
            while (isoption == false)
            {
                Console.Write("\n1. Create an account\n2. Perform other operrations\n=>");
                string op = Console.ReadLine();
                if (op == "1")
                {
                    isoption = true;
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Pin: ");
                    string pin = Console.ReadLine();
                    Random nh = new Random();
                    int acc_no = nh.Next(10000000, 99999999);
                    Validation nm = new Validation(name, acc_no, pin, database);
                    Console.WriteLine("Your account has been created your account number is{0}", acc_no);
                    database.Add(nm);
                    isoption = false;


                }

                else if (op == "2")

                {
                    
                    Console.Write("Input your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Input your account number: ");
                    int acc = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input your pin: ");
                    string pin = Console.ReadLine();

                    Validation stt = new Validation(name, acc, pin, database);
                    stt.Welcome();
                    stt.login(acc, pin, database);
                    isoption = true;
                    bool IsOption = false;
                    while (IsOption == false)
                    {
                        Console.Write("Choose an option\n1. Withdrawal\n2. Deposit\n3. Check balance.\n=>");
                        string option = Console.ReadLine();
                        if (option == "1")
                        {
                            IsOption = true;
                            if (stt.IsLoggedin == true)
                            {
                                Console.Write("\nhow much do you want to withdraw: ");
                                decimal amt = Decimal.Parse(Console.ReadLine());
                                BankOp st = new BankOp(database);
                                st.withdrawal(acc, amt, database);
                                st.Thank_you();
                                break;
                            }
                            else
                            {
                                break;
                            }

                        }
                        else if (option == "2")
                        {
                            IsOption = true;
                            if (stt.IsLoggedin == true)
                            {
                                Console.Write("\nhow much do you want to deposit: ");
                                decimal amt = Decimal.Parse(Console.ReadLine());
                                BankOp st = new BankOp(database);
                                st.deposit(acc, amt, database);
                                st.Thank_you();//Overridden abstract method 
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (option == "3")
                        {
                            if (stt.IsLoggedin == true)
                            {

                                BankOp st = new BankOp(database);
                                st.check_balance(acc, database);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");                          
                        }
                        Console.WriteLine("Do you want to still carry out an operation?\n");
                        Console.Write("1. yes\n2. no\n =>");
                        string opt = Console.ReadLine();
                        if (opt == "1")
                        {
                            IsOption = false;
                        }
                        else
                        {
                            IsOption = true;

                        }

                    }
                    
                }
                else
                {
                    Console.WriteLine("Wrong input");
                    break;
                }

            }
        }

    }
}
