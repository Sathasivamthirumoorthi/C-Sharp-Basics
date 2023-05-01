using System;

namespace MyInterface{

    class TestBank{

        static void main(string[] args)
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
                    Customer sathasivam = new IndividualCustomer("sathasivam");


                    Console.WriteLine("Select type of account");
                    Console.WriteLine();
                    Console.WriteLine("1 Loan Account");
                    Console.WriteLine("2 Deposit Account");
                    Console.WriteLine("3 Mortage Account");

                    accountType = Convert.ToInt32(Console.ReadLine());

                    double interest;

                    switch (accountType)
                    {
                        case 1:
                            LoanAccount individualLoanAccount = new LoanAccount(sathasivam, 1000);
                            interest = individualLoanAccount.calculate_interest(6); 
                            Console.WriteLine("Interest for loan account is: " + interest);
                            break;

                        case 2:
                            DepositAccount individualDepositAccount = new DepositAccount(sathasivam, 500); 
                            individualDepositAccount.deposit(100); 
                            individualDepositAccount.withdraw(50); 
                            interest = individualDepositAccount.calculate_interest(6); 
                            Console.WriteLine("Interest for deposit account is: " + interest);
                            break;

                        case 3:
                            MortageAccount individualMortageAccount = new MortageAccount(sathasivam, 100000); 
                            interest = individualMortageAccount.calculate_interest(12);
                            Console.WriteLine("Interest for mortage account is: " + interest);
                            break;

                        default:
                            Console.WriteLine("Invalid account type");
                            break;
                    }
                    
                    break;

                case 2:
                    CompanyCustomer google = new CompanyCustomer("Google");
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
                                LoanAccount companyLoanAccount = new LoanAccount(google, 1000); // example account object
                                interest = companyLoanAccount.calculate_interest(6); // example interest calculation
                                Console.WriteLine("Interest for loan account is: " + interest);
                                break;

                            case 2:
                                DepositAccount companyDepositAccount = new DepositAccount(google, 500); // example account object
                                companyDepositAccount.deposit(100); // example deposit action
                                companyDepositAccount.withdraw(50); // example withdrawal 
                                interest = companyDepositAccount.calculate_interest(6); // example interest calculation
                                Console.WriteLine("Interest for deposit account is: " + interest);

                                break;

                            case 3:
                                MortageAccount companyMortageAccount = new MortageAccount(google, 100000); // example account object
                                interest = companyMortageAccount.calculate_interest(12); // example interest calculation
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