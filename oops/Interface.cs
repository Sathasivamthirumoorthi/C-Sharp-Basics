using System;

namespace MyProblem{
    interface IEmployee
    {

        // cannot contain instance variable        
        // int name = 21;

        void Welcome(string name);

        void Greetting(string name);    

        void company(){
            Console.WriteLine("XYZ company");
        }



    }


    interface IHuman{
        void name(string name);
    }

    class Employer : IEmployee , IHuman{
        public void Welcome(string name){
            Console.WriteLine("Welcome : {0} ",name);
        }
        public void Greetting(string name){
            Console.WriteLine("Name : {0} , Good Morning",name);
        }

        public void name(string name){
            Console.WriteLine("My name is {0} ",name);
        }
    }


    class Candidate : IEmployee{
        void IEmployee.Greetting(string name){
            Console.WriteLine("Name : {0} ",name);
        }

        void IEmployee.Welcome(string name){
            Console.WriteLine("Name : {0} , Good Morning",name);
        }
    }


    class TestInterface{
        // public static void Main(string[] args){
        //     IEmployee emp = new Employer();
        //     emp.company();
        // }
    }

}