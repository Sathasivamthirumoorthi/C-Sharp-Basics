using System;

namespace MyInterface{
    // Define a class named DepositAccount which implement from the abstract Account class.
class DepositAccount : Account{

    // Define a constructor which takes in a Customer object and a starting accountBalance, and calls the base constructor.
    public DepositAccount(Customer customer, float accountBalance) : base(customer,accountBalance){
    }

    // Define a method named withdraw which takes in a float amount and subtracts it from the account accountBalance.
    public void withdraw(float amount){
       // Print a message to the console to indicate the amount being withdrawn.
        Console.WriteLine("Amount to be widthdraw : {0}" , amount);
    
        // Subtract the withdrawal amount from the account accountBalance.
        accountBalance -= amount;

        // Print a message to the console to indicate the withdrawal has been made and the current accountBalance.
         Console.WriteLine("{0} is widthdrawn from your bank account ",amount);
        Console.WriteLine("Your current accountBalance is {0}: ",accountBalance);   
    }

    // Define a static method named withdrawing which takes in an int amount (although it is not used in the method).
    public static void withdrawing(int amount){
        // This method does not do anything and can be removed.
    }

    // Override the abstract calculate_interest method from the Account class.
    public override double calculate_interest(int noOfMonths){
        // If the account accountBalance is greater than or equal to 1000, calculate and return the interest amount for the given number of months.
        if(accountBalance >= 1000){
            return noOfMonths*interest_rate;
        }
        // Otherwise, return 0 interest.
        else{
            return 0;
        }
    }
}

}