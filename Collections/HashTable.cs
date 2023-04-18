// // The Hashtable class represents a collection of key-and-value pairs that are organized 
// // based on the hash code of the key. It uses the key to access the elements in the collection.

// using System;
// using System.Collections;

// namespace MyNamespace {
//    class Program {
//       static void Main(string[] args) {
//          Hashtable ht = new Hashtable();
         
//          ht.Add("001", "A");
//          ht.Add("002", "S");
//          ht.Add("003", "F");
//          ht.Add("004", "F");
//          ht.Add("005", "F");
//          ht.Add("006", "G");
//          ht.Add("007", "D");
         
//          if (ht.ContainsValue("A")) {
//             Console.WriteLine("This student name is already in the list");
//          } else {
//             ht.Add("008", "A");
//          }
         
         
//          foreach (string k in ht.Keys) {
//             Console.WriteLine(k + ": " + ht[k]);
//          }

         
//       }
//    }
// }