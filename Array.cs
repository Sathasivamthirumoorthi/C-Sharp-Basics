using System;
using System.Collections;
namespace Arrays{


    class Problem{

        // Write a program in C# Sharp to read n number of values in an array and display it in reverse order. 
        public static void reverseArray(int[] arr){
            for(int i = arr.Length -1 ; i >= 0;i--){
                Console.WriteLine(arr[i]);
            } 
        }

        // Write a program in C# Sharp to find the sum of all elements of the array. 

        public static void sumOfArray(int[] arr){
            int sum = 0;
            for(int i = arr.Length -1 ; i >= 0;i--){
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }



        public static void duplicate(int[] arr){
            Hashtable dic = new Hashtable();

            for(int i = 0;i < arr.Length;i++){
                if(dic.ContainsKey(arr[i])){
                    dic[arr[i]] = (int)dic[arr[i]] + 1;
                    
                }else{
                    dic[arr[i]] = 1;
                }
            }

            int count = 0;
            foreach(int value in dic.Values)
            {
                if(value > 1){
                    count++;
                }
            }

            Console.WriteLine("Count of duplicates {0}",count);
        }



        // C# Sharp to print all unique elements in an array. 

        public static void unique(int[] arr){
            Hashtable dic = new Hashtable();

            for(int i = 0;i < arr.Length;i++){
                if(dic.ContainsKey(arr[i])){
                    dic[arr[i]] = (int)dic[arr[i]] + 1;
                    
                }else{
                    dic[arr[i]] = 1;
                }
            }

            int count = 0;
            
            // foreach(int key in dic.Keys){
            //     Console.WriteLine(key);
            // }
            for(int i = 0;i < dic.Count;i++){
                if((int)dic[arr[i]] == 1){
                    Console.WriteLine(arr[i]);
                }
                
            }

        }



        // C# Sharp to merge two arrays of same size sorted in ascending order.  


        public static void mergeArray(int[] arr1 , int[] arr2){
            int[] res = new int[arr1.Length + arr2.Length];


            int count = 0;
            for(int i = 0;i < arr1.Length;i++){
                res[count] = arr1[i];
                count++;
            }
            for(int i = 0;i < arr1.Length;i++){
                res[count] = arr1[i];
                count++;
            }
            
            // Array.ForEach(res,Console.WriteLine);
            Console.WriteLine("[{0}]",string.Join(", ",res));
        }


        
        // C# Sharp to count the frequency of each element of an array.  

        public static void frequency(int[] arr){
            Hashtable dic = new Hashtable();

            for(int i = 0;i < arr.Length;i++){
                if(dic.ContainsKey(arr[i])){
                    dic[arr[i]] = (int)dic[arr[i]] + 1;
                    
                }else{
                    dic[arr[i]] = 1;
                }
            }

            int count = 0;
            foreach(int key in dic.Keys)
            {
                Console.WriteLine(key + " -----> " +  dic[key]);
            }

        }

        // C# Sharp to separate odd and even integers in separate arrays.  



        public static void oddEven(int[] arr){
            ArrayList odd = new ArrayList(); 
            ArrayList even = new ArrayList(); 

            
            for(int i = 0; i < arr.Length;i++){
                if(arr[i] % 2 == 0){
                    even.Add(arr[i]);
                }else{
                    odd.Add(arr[i]);
                }
            }
            foreach(var item in odd)
            {
                Console.WriteLine("The nodes of odd are:" + item);
            }
            
            Console.WriteLine("----------------------------------");

            foreach(var item in even)
            {
                Console.WriteLine("The nodes of even are:" + item);
            }


        }



        public static void Main(string[] args){
            int[] arr1 = {1,2,3,4,5,6,6,1,2,1};
            int[] arr2 = {1,2,3,4,5,6,6,1,2,1};

            // reverseArray(arr);
            // unique(arr);
            // oddEven(arr1);
            var s = "Siva";
            Console.Write(s);
        }

    }
}



// using System;


// // Array 

// namespace Arrays{
//     class Problem{


//         public static void change(string s){
//             s = "String";
//             Console.WriteLine(s);

//         }

//         public static void Main(String[] args){

//             int[] arr = new int[10];

//             string[] str = new string[10];

//             for(int i = 1;i < str.Length;i++){
//                 str[i] = "hello";
//             }

//             int[] arr1= {1,2,3,4,5,6,6,7,8};

//             // Array.ForEach(arr1,Console.WriteLine);

//             int[] arr2 = new int[] {1,2,3,4,45,6,7};
//             int[,] multiDimensionalArray1 = new int[2, 3];

//             foreach(int item in multiDimensionalArray1){
//                 Console.WriteLine(item);
//             }


//             // Console.WriteLine("[{0}]" , string.Join(",",multiDimensionalArray1));

//         }

//     }
// }












