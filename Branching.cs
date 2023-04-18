
using System;
 
namespace Sample
{
	class Test
	{

        public static void isEqual(int num1 , int num2){
            if(num1 == num2){
                Console.WriteLine("Values {0} and {1} are equal ",num1 ,num2);

            }else{
                Console.WriteLine("Values {0} and {1} are not equal ",num1 ,num2);

            }
        }


        public static void oddOrEven(int num){
            if(num%2 == 0){
                Console.WriteLine("Value {0} is even",num);
            }else{
                Console.WriteLine("Value {0} is odd",num);

            }
        }


        public static void isPositive(int num){
            if(num >= 0){
                Console.WriteLine("Value {0} is positive",num);
            }else{
                Console.WriteLine("Value {0} is negative",num);

            }
        }


        public static void isLeapYear(int year){

            if (year % 400 == 0 && year % 100 == 0){
                Console.WriteLine("{0} is leap year",year);
            }else if(year % 4 == 0 && year % 100 != 0){
                Console.WriteLine("{0} is leap year",year);
            }else{
                Console.WriteLine("{0} is leap not a year",year);

            }

        }

        public static void eligibleForVote(int age){
            if(age >= 18){
                Console.WriteLine("{0} is eligible to vote",age);
                
            }else{
                Console.WriteLine("{0} is not eligible to vote",age);

            }
        }


        public static void showN(int m){
            int n = 0;
            if(m == 0){
                Console.WriteLine(n);
            }else if(m > 0){
                n = 1;
                Console.WriteLine(n);
            }else{
                n = -1;
                Console.WriteLine(n);
            }
        }
     

            // largestOfThreeNumbers(4,33,3);

        public static void showHeight(float height){

            if(height < 150.0){
                Console.WriteLine("The person is dwarf");
            }
            else if(height >= 150.0 && height <= 165.0){
                Console.WriteLine("The person is avarage height");
            }
            else if(height >= 165.0 && height <= 195.0){
                Console.WriteLine("The person is taller");

            }else{
                Console.WriteLine("The person is abnormal height");

            }

        }

        public static void largestOfThreeNumbers(int n1,int n2 , int n3){
            if(n1 > n2 && n1 > n3){
                Console.WriteLine("n1 {0} is greatest",n1);
            }else if(n2 > n1 && n2 > n3){
                Console.WriteLine("n2 {0}  is greatest",n2);

            }else{
                Console.WriteLine("n3 {0} is greatest",n3);

            }
        }

       
       public static void quandrant(int c1,int c2){
        if(c1 > 0 &&  c2 > 0){
            Console.WriteLine("The coordinate point ({0},{1}) lies in the first quandrant",c1,c2);   
        }
        else if(c1 < 0 && c2 > 0){
            Console.WriteLine("The coordinate point ({0},{1}) lies in the second quandrant",c1,c2);   
        }
        else if(c1 < 0 && c2 < 0){
            Console.WriteLine("The coordinate point ({0},{1}) lies in the third quandrant",c1,c2);   
        }
        else if(c1 > 0 && c2 < 0){
            Console.WriteLine("The coordinate point ({0},{1}) lies in the fourth quandrant",c1,c2);   
        }
        else if(c1 == 0 && c2 == 0){
            Console.WriteLine("The coordinate point ({0},{1}) lies origin",c1,c2);   
        }
       }

        
        // admission(65,2,50);

       public static void admission(int m , int p , int c ){
            int total_of_all , total_of_three;
        
            total_of_all = m + p + c;

            total_of_three = m + p;


            if (m >= 65 && p >= 55 && c >= 50){
                Console.WriteLine("Candidate is eligible");
            }
            else if (total_of_all >= 180 || total_of_three >= 140 ){
                Console.WriteLine("Candidate is eligible");
            }else{
                Console.WriteLine("Candidate is not eligible");

            }
       }








		// public static void Main(string[] args)
		// {
		// 	string str;
        //     int num1 , num2;
		// 	Console.Write("Enter a number1 - ");
		// 	str = Console.ReadLine();
        //     num1 = Int32.Parse(str);
        //     // float height = float.Parse(str);
		// 	Console.Write("Enter a number2 - ");
		// 	str = Console.ReadLine();
        //     num2 = Int32.Parse(str);
            
        //     // isEqual(num1,num2);
            
        //     // oddOrEven(num1);

        //     // isPositive(num1);


        //     // eligibleForVote(num1);
        //     // isLeapYear(num1);

        //     // showN(num1);

        //     // showHeight(height);

        //     // largestOfThreeNumbers(4,33,3);

        //     admission(65,2,50);

        //     // quandrant(num1,num2);


		// }
	}
}