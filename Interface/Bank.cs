using System;

namespace MyInterface{
interface Bank{
    public double calculate_interest(int months);
}
abstract class Account : Bank{

        public Customer customer;

        public float balance;

        public float interest_rate = 24;  

        public abstract double calculate_interest(int months);

        public void deposit(float amount){
            Console.WriteLine("Your depositing amount : {0}" , amount);
            balance += amount;
            Console.WriteLine("{0} is added to bank account ",amount);
            Console.WriteLine("Your current balance is : {0}",balance);   
        }

        public void getBalance(){
            Console.WriteLine("Your current balance : {0}", balance);
        }

        public Account(Customer customer,float balance){
            this.customer = customer;
            this.balance = balance;
        }
    }


    class DepositAccount : Account{

        public DepositAccount(Customer customer, float balance) : base(customer,balance){
        }


    
        
        public void withdraw(float amount){
            Console.WriteLine("Amount to be widthdraw : {0}" , amount);
            balance -= amount;
            Console.WriteLine("{0} is widthdrawn from your bank account ",amount);
            Console.WriteLine("Your current balance is {0}: ",balance);   
        }

        public static void withdrawing(int amount){
            
        }

        public override double calculate_interest(int months){
            if(balance >= 1000){
                return months*interest_rate;
            }else{
                return 0;
            }

        }
        
    }

    class LoanAccount : Account{

        public LoanAccount(Customer customer, float balance) : base(customer,balance){
        }



        public override double calculate_interest(int months)
        {
            if(customer is IndividualCustomer){

                if(months <= 3){
                    return 0;
                }
                else{
                    return interest_rate * (months - 3);
                }

            }else{
                if(months <= 2){
                    return 0;
                }
                else{
                    return interest_rate * (months - 2);
                }
            }

        }


    }

    class MortageAccount : Account{
        
        public MortageAccount(Customer customer, float balance) : base(customer,balance){
        }
        public override double calculate_interest(int months)
        {
            if(customer is IndividualCustomer){
                if(months <= 6){
                    return 0;
                }else{
                    return (months - 6) * interest_rate;
                }

            }else{
                if(months <= 12){
                    return 0.5 * interest_rate * months;
                }else{
                    return (months - 12) * interest_rate;
                }
            }
        }

    }



    abstract class Customer{

        public string name;

        public Customer(string name){
            this.name = name;
        }

        public string Greetinmg(){
            return "greeting";
        }        
    }


    class IndividualCustomer : Customer{

        public IndividualCustomer(string name) : base(name){}


    }

    class CompanyCustomer : Customer{

        public CompanyCustomer(string name) : base(name){}
    }





    // class TestBank{
    //     public static void Main(string[] args){

    //         IndividualCustomer indivudual;
    //         // indivudual.name = ""
          
    //     }
    // }


}



// A bank have 3 types of accounts 

// Deposit 
// loan 
// mortage 


// customers - individual , company 


// All accounts have 
    //customers , balance , interest rate 
    // interest (method) -  number_of_months * interest_rate.
// Deposit - depositing , withdrawing 
// loan - depositing
// mortage - depositing



// loan - 
    // have no interest rate during first 3 months by individual
    // 2 months by company 

// deposit 
    // if balance is positive and less than 1000- no interest rate

//Mortage 
    // 1 / 2 interest rate - first 12 months
    // no interest rate - first 6 months




// interface Bank -- customers , balance , interest rate   and method (interest)

// implement different accounts - 


// All should have interface members and its own members 

// Deposit 

// loan 

// mortage 

// customers 

// individual : loan
// individual : deposit
// individual : mortage

// company : loan
// company : deposit
// company : mortage





