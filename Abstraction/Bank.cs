// Create an abstract class 'Bank' with an abstract method 'getBalance'. 
// $100, $150 and $200 are deposited in banks A, B and C respectively. 'BankA', 
// 'BankB' and 'BankC' are subclasses of class 'Bank', each having a method 
// named 'getBalance'. Call this method by creating an object of each of the three classes. 

using System;

namespace MyProblem
{
    abstract class Bank{
        public abstract int getBalance();
    }
    class BankA : Bank{

        private int deposited;

        public BankA(int deposited){
            this.deposited = deposited;
        }

        public override int getBalance()
        {
            return deposited;
        }
    }

    
    class BankB : Bank{

        private int deposited;

        public BankB(int deposited){
            this.deposited = deposited;
        }

        public override int getBalance()
        {
            return deposited;
        }
    }
    
    class BankC : Bank{

        private int deposited;

        public BankC(int deposited){
            this.deposited = deposited;
        }

        public override int getBalance()
        {
            return deposited;
        }
    }


}