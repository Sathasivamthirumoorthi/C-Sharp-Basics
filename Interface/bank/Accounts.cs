using System;

namespace MyInterface{

// Define an abstract class named Account which implements the Bank interface.
abstract class Account : Bank{

    // Define two public instance variables: a Customer object and a float for the account accountBalance.
    public Customer bankCustomer;
    public float accountBalance;

    // Define a default interest rate of 24%.
    public float interest_rate = 24;  

    // Define an abstract method named calculate_interest which calculates the interest amount for the given number of months.
    public abstract double calculate_interest(int months);

    // Define a method named deposit which takes in a float amount and adds it to the account accountBalance.
    public void deposit(float amount){
        // Print a message to the console to indicate the amount being deposited.
        Console.WriteLine("Your depositing amount : {0}" , amount);
        
        // Add the deposit amount to the account accountBalance.
        accountBalance += amount;

        // Print a message to the console to indicate the deposit has been added to the account.
        Console.WriteLine("{0} is added to bank account ",amount);

        // Print a message to the console to indicate the current accountBalance after the deposit.
        Console.WriteLine("Your current Account Balance is : {0}",accountBalance);   
    }

    // Define a method named getaccountBalance which prints the current account accountBalance to the console.
    public void getAccountBalance(){
        Console.WriteLine("Your current accountBalance : {0}", accountBalance);
    }

    // Define a constructor which takes in a Customer object and a starting accountBalance, and sets the instance variables.
    public Account(Customer bankCustomer,float accountBalance){
        this.bankCustomer = bankCustomer;
        this.accountBalance = accountBalance;
    }
}










}