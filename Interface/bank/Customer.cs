using System;

namespace MyInterface{

    // Define an abstract class named Customer.
    abstract class Customer{

        // Define a public string field named 'name'.
        public string name;

        // Define a constructor which takes in a string 'name' and assigns it to the 'name' field.
        public Customer(string name){
            this.name = name;
        }

        // Define a public method named 'Greeting' which returns a string.
        public string Greetinmg(){
            return "greeting";
        }        
    }


    // Define a class named IndividualCustomer which inherits from the Customer class.
    class IndividualCustomer : Customer{

        // Define a constructor which takes in a string 'name' and calls the base constructor.
        public IndividualCustomer(string name) : base(name){}
    }


    // Define a class named CompanyCustomer which inherits from the Customer class.
    class CompanyCustomer : Customer{

        // Define a constructor which takes in a string 'name' and calls the base constructor.
        public CompanyCustomer(string name) : base(name){}
    }
    
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





