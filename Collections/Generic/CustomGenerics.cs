using System;
using System.Collections.Generic;

namespace MyNamespace{

    class MyGenericArray<T>{
        private T[] array;
        int count;
        public MyGenericArray(int size){
            array = new T[size + 1];
            count = size + 1;
        }

        public int length(){
            return count;
        }

        public T getItem(int index){
            return array[index];
        }

        public void setItem(int index,T value){
            array[index] = value;
        }

    }

    // class TestGeneric{
    //     public static void Main(string[] args){
    //         MyGenericArray<int> myGenericArray = new MyGenericArray<int>(5);

    //         myGenericArray.setItem(0,26);
    //         myGenericArray.setItem(1,25);
    //         myGenericArray.setItem(2,24);
    //         myGenericArray.setItem(3,22);
    //         myGenericArray.setItem(4,23);

    //         for(int i = 0; i < myGenericArray.length();i++){
    //             Console.WriteLine(myGenericArray.getItem(i));
    //         }


    //     }
    // }
}