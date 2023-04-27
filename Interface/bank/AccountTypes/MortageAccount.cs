using System;

namespace MyInterface{

    // Define a class named MortageAccount which implements from the abstract Account class.
class MortageAccount : Account{
        
    // Define a constructor which takes in a Customer object and a starting balance, and calls the base constructor.
    public MortageAccount(Customer bankCustomer, float balance) : base(bankCustomer,balance){
    }

    // Override the abstract calculate_interest method from the Account class.
    public override double calculate_interest(int noOfMonths)
    {
        // If the bankCustomer is an IndividualCustomer, calculate the interest amount based on the number of months and the interest rate.
        if(bankCustomer is IndividualCustomer){
            // If the number of months is less than or equal to 6, return 0 interest.
            if(noOfMonths <= 6){
                return 0;
            }
            // Otherwise, calculate and return the interest amount for the given number of months.
            else{
                return (noOfMonths - 6) * interest_rate;
            }
        }
        // If the bankCustomer is not an IndividualCustomer, calculate the interest amount based on the number of months and the interest rate.
        else{
            // If the number of months is less than or equal to 12, return 0.5 * interest_rate * months interest.
            if(noOfMonths <= 12){
                return 0.5 * interest_rate * noOfMonths;
            }
            // Otherwise, calculate and return the interest amount for the given number of months.
            else{
                return (noOfMonths - 12) * interest_rate;
            }
        }
    }
}

}