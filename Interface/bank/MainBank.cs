using System;

namespace MyInterface{

    class TestBank{

        static void Main(string[] args)
        {
            // Get the type of customer (individual or company)

            Console.WriteLine("Type of Customer");
            Console.WriteLine();
            Console.WriteLine("1  Individual Customer ");
            Console.WriteLine("2  Company");
            Console.WriteLine();

            int customerType = Convert.ToInt32(Console.ReadLine());
            int accountType;

            // Switch case for customer type
            switch (customerType)
            {
                case 1:
                    Customer individualCustomer = new IndividualCustomer("John Doe"); // example customer object


                    Console.WriteLine("Select type of account");
                    Console.WriteLine();
                    Console.WriteLine("1 Loan Account");
                    Console.WriteLine("2 Deposit Account");
                    Console.WriteLine("3 Mortage Account");

                    accountType = Convert.ToInt32(Console.ReadLine());

                    double interest;
                    // Switch case for account type for individual customer
                    switch (accountType)
                    {
                        case 1:
                            LoanAccount loanAccount = new LoanAccount(individualCustomer, 1000); // example account object
                            interest = loanAccount.calculate_interest(6); // example interest calculation
                            Console.WriteLine("Interest for loan account is: " + interest);
                            break;

                        case 2:
                            DepositAccount depositAccount = new DepositAccount(individualCustomer, 500); // example account object
                            depositAccount.deposit(100); // example deposit action
                            depositAccount.withdraw(50); // example withdrawal 
                            interest = depositAccount.calculate_interest(6); // example interest calculation
                            Console.WriteLine("Interest for deposit account is: " + interest);
                            break;

                        case 3:
                            MortageAccount mortageAccount = new MortageAccount(individualCustomer, 100000); // example account object
                            interest = mortageAccount.calculate_interest(12); // example interest calculation
                            Console.WriteLine("Interest for mortage account is: " + interest);
                            break;

                        default:
                            Console.WriteLine("Invalid account type");
                            break;
                    }
        break;

            case 2:
                CompanyCustomer companyCustomer = new CompanyCustomer("Google");
                Console.WriteLine("Select type of account");
                Console.WriteLine();
                Console.WriteLine("1 Loan Account");
                Console.WriteLine("2 Deposit Account");
                Console.WriteLine("3 Mortage Account");

                accountType = Convert.ToInt32(Console.ReadLine());
                // Switch case for account type for company customer
                switch (accountType)
                    {
                        case 1:
                            LoanAccount loanAccount = new LoanAccount(companyCustomer, 1000); // example account object
                            interest = loanAccount.calculate_interest(6); // example interest calculation
                            Console.WriteLine("Interest for loan account is: " + interest);
                            break;

                        case 2:
                            DepositAccount depositAccount = new DepositAccount(companyCustomer, 500); // example account object
                            depositAccount.deposit(100); // example deposit action
                            depositAccount.withdraw(50); // example withdrawal 
                            interest = depositAccount.calculate_interest(6); // example interest calculation
                            Console.WriteLine("Interest for deposit account is: " + interest);

                            break;

                        case 3:
                            MortageAccount mortageAccount = new MortageAccount(companyCustomer, 100000); // example account object
                            interest = mortageAccount.calculate_interest(12); // example interest calculation
                            Console.WriteLine("Interest for mortage account is: " + interest);
                            break;

                        default:
                            Console.WriteLine("Invalid account type");
                            break;
                    }
                break;

            default:
                Console.WriteLine("Invalid customer type");
                break;
        }

        }
    }
}