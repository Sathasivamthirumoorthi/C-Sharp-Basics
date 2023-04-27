using System;

namespace MyInterface{

    // Define a class named LoanAccount which implement from the abstract Account class.
class LoanAccount : Account{

    // Define a constructor which takes in a bankCustomer object and a starting balance, and calls the base constructor.
    public LoanAccount(Customer bankCustomer, float balance) : base(bankCustomer,balance){
    }

    // Override the abstract calculate_interest method from the Account class.
    public override double calculate_interest(int noOfMonths)
    {
        // If the bankCustomer is an IndividualCustomer, calculate the interest amount based on the number of months and the interest rate.
        if(bankCustomer is IndividualCustomer){

            // If the number of months is less than or equal to 3, return 0 interest.
            if(noOfMonths <= 3){
                return 0;
            }
            // Otherwise, calculate and return the interest amount for the given number of months.
            else{
                return interest_rate * (noOfMonths - 3);
            }

        }
        // If the bankCustomer is not an IndividualCustomer, calculate the interest amount based on the number of months and the interest rate.
        else{
            // If the number of months is less than or equal to 2, return 0 interest.
            if(noOfMonths <= 2){
                return 0;
            }
            // Otherwise, calculate and return the interest amount for the given number of months.
            else{
                return interest_rate * (noOfMonths - 2);
            }
        }
    }
}

}