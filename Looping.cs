


using System;

namespace Looping
{
    class Problem{


        public static void naturalNumbers(){
            for(int i = 1; i <= 10; i++){
                Console.WriteLine(i);
            }
        }

        public static void sumOfNaturalNumbers(){
            int sum = 0;
            for(int i = 1; i <= 10; i++){
                sum += i;
            }
            Console.WriteLine("Sum is " + sum);
        }

         public static void naturalSum(int n){
            int sum = 0;

            for(int i = 1; i <= n; i++){
                sum += i;

                Console.WriteLine(i);
            }

            Console.WriteLine("The sum of natural numbers are {0}",sum);
        }

        public static void cube(int n){
            int cube = 1;
            for(int i = 1; i <= n; i++){
                cube = i*i*i;
                Console.WriteLine("Numbers is {0} : and cube of {0} is {1}",i,cube);
            }
        }
        public static void table(int n){
            int m = 1;
            for(int i = 1; i <= n; i++){
                int val = n * i;
                Console.WriteLine(n + "* {0} = {1}",i,val);
            }
        }


         public static void tableVertically(int n){
            int m = 1;
            for(int i = 1; i <= n; i++){
                int val = n * i;
                Console.Write(n + "* {0} = {1}    ",i,val);
            }
        }


         public static void oddNumbers(int n){
            int sum = 0;
            for(int i = 1; i <= 10; i++){
                if(i%2 != 0){
                    sum += i;
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("Sum of {0} odd numbers is {1} ",n,sum);

        }

         public static void asteriskPattern(int n){
            for(int i = 1; i <= n; i++){
                for(int j = 0;j < i;j++){
                Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }


         public static void numberPattern(int n){
            for(int i = 1; i <= n; i++){
                for(int j = 1;j <= i;j++){
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }




        // public static void Main(String[] args){
            
        //     numberPattern(12);
        // }
    }
    
}
