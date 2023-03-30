// //List

// using System;
// using System.Collections.Generic;


List<int> primeNumbers = new List<int>();
primeNumbers.Add(2);
primeNumbers.Add(3);

int[] oddArray = {5,7};

Stack<int> oddStack = new Stack<int>();
oddStack.Push(9);
oddStack.Push(11);

Queue<int> oddQueue = new Queue<int>();
oddQueue.Enqueue(13);
oddQueue.Enqueue(15);

primeNumbers.AddRange(oddArray);
primeNumbers.AddRange(oddStack);
primeNumbers.AddRange(oddQueue);

primeNumbers.Insert(0,1);

var isPresent = primeNumbers.Contains(4);
Console.WriteLine(isPresent);


var removedItems = primeNumbers.Remove(2);
Console.WriteLine("Original List of prime numbers");
foreach (var item in primeNumbers) {
    Console.Write(item+"\t");
}
Console.WriteLine();

Console.WriteLine("Sorted List of prime numbers");
primeNumbers.Sort();
foreach (var item in primeNumbers) {
    Console.Write(item+"\t");
}
Console.WriteLine();

Console.WriteLine("Reverse Sorted List of prime numbers");
primeNumbers.Reverse();
foreach (var item in primeNumbers) {
    Console.Write(item+"\t");
}
Console.WriteLine();






// namespace GenericListCollectionDemo
// {
//     class Program
//     {
//         static void Main()
//         {
//             //Creating a Generic List of string type to store car brands
//             List<string> carBrands = new List<string>();

//             //Adding elements to the carBrands list using the Add method
//             carBrands.Add("Honda");
//             carBrands.Add("Toyota");

//             //Creating a new array of car brands
//             string[] moreCarBrands = { "Ford", "Chevrolet" };

//             //Creating a new Stack of car brands
//             Stack<string> stackCarBrands = new Stack<string>();
//             stackCarBrands.Push("BMW");
//             stackCarBrands.Push("Mercedes");

//             //Creating a new Queue of car brands
//             Queue<string> queueCarBrands = new Queue<string>();
//             queueCarBrands.Enqueue("Nissan");
//             queueCarBrands.Enqueue("Mazda");

//             //Adding the car brands from different collections to the "carBrands" list using the AddRange method
//             carBrands.AddRange(moreCarBrands);
//             carBrands.AddRange(stackCarBrands);
//             carBrands.AddRange(queueCarBrands);

//             //Inserting a new element at a specific position
//             carBrands.Insert(2, "Audi");

//             //Checking if an element is present in the list using the Contains method
//             var isPresent = carBrands.Contains("Toyota");
//             Console.WriteLine($"Is Toyota present in the list? {isPresent}");

//             //Removing an element from the list using the Remove method
//             var removedItem = carBrands.Remove("Honda");
//             Console.WriteLine($"\nRemoved item: {removedItem}");

//             //Removing all the elements that match a condition using the RemoveAll method
//             var removedAll = carBrands.RemoveAll(c => c.StartsWith("M"));
//             Console.WriteLine($"\nNumber of items removed: {removedAll}");

//             //Clearing the entire list using the Clear method
//             //carBrands.Clear();

//             //Copying the elements of the list to an array using the CopyTo method
//             string[] carBrandsArray = new string[carBrands.Count];
//             carBrands.CopyTo(carBrandsArray);

//             //Finding the first element that matches a condition using the Find method
            // var firstMatch = carBrands.Find(c => c.StartsWith("F"));
//             Console.WriteLine($"\nFirst match: {firstMatch}");

//             //Finding all the elements that match a condition using the FindAll method
//             var allMatches = carBrands.FindAll(c => c.StartsWith("B"));
//             Console.WriteLine("\nAll matches:");
//             foreach (var match in allMatches)
//             {
//                 Console.WriteLine(match);
//             }

//             //Finding the last element that matches a condition using the FindLast method
//             var lastMatch = carBrands.FindLast(c => c.StartsWith("N"));
//             Console.WriteLine($"\nLast match: {lastMatch}");

//             //Sorting the list using the Sort method
//             carBrands.Sort();

//             //Reversing the order of the elements in the list using the Reverse method
//             carBrands.Reverse();

//             //Accessing the car brands in the "carBrands" list using foreach loop
//             Console.WriteLine("\nCar Brands:");
//             foreach (var carBrand in carBrands)
//             {
//                 Console.WriteLine(carBrand);
//             }

//             Console.ReadKey();
//         }
//     }
// }
