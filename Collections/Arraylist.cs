// using System;
// using System.Collections;


// //  It is basically an alternative to an array. However, unlike 
// //  array you can add and remove items from a list at a specified position using an index and the array resizes itself automatically. 
// //  It also allows dynamic memory allocation, adding, searching and sorting items in the list.

// namespace MyNamespace {
//    class Program {
//         public static void Main(string[] args) {
//          ArrayList al = new ArrayList();
//          ArrayList arrayList = new ArrayList();
         
//          Console.WriteLine("Adding some numbers:");
//          al.Add(45);
//          al.Add(78);
//          al.Add(33);
//          al.Add(56);
//          al.Add(12);
//          al.Add(23);
//          al.Add(9);
         
//          Console.WriteLine("Capacity: {0} ", al.Capacity);
//          Console.WriteLine("Count: {0}", al.Count);
         
//          Console.Write("Content: ");
//          foreach (int i in al) {
//             Console.Write(i + " ");
//          }
         
//          Console.WriteLine();
//          Console.Write("Sorted Content: ");
//          al.Sort();
//          foreach (int i in al) {
//             Console.Write(i + " ");
//          }

//         Console.WriteLine("Adding some strings");

//         arrayList.Add("A");
//         arrayList.Add(1);
//         arrayList.Add("C");
//         arrayList.Add("D");

//         arrayList.Reverse();

//         Console.WriteLine("Count {0}",arrayList.Count);

//         Console.WriteLine("Capacity {0}",arrayList.Capacity);


//         // Array.ForEach(arrayList, val => Console.Write("{0} ", val));
//         arrayList.Remove("A");
//         foreach(var i in arrayList){
//             Console.WriteLine(i + "  ");
//         }




//          Console.WriteLine(arrayList.IsReadOnly);
//          Console.WriteLine(arrayList.IndexOf("A"));

//          Console.ReadKey();
//       }
//    }




// }
