
using System.Collections.Generic;
using System.Collections;
Dictionary<string, string> dictionary = new();
dictionary.Add("monokotil", "apel");
dictionary.Add("dicotil", "pisang");

Dictionary<string, string> dictionary2 = new();
dictionary2.Add("mamalia", "kucing");
dictionary2.Add("unggas", "ayam");

Dictionary<string, Dictionary<string, string>> dictionary3 = new();
dictionary3.Add("buah",dictionary);
dictionary3.Add("hewan", dictionary2);

foreach (var dic3 in dictionary3) 
{
    foreach (var dic in dic3.Value)
    {
        Console.WriteLine(dic3.Key + " : " + dic);
    }
}

foreach (var dic3 in dictionary3) 
{
    Console.Write(dic3.Key + " : ");
    foreach (var dic in dic3.Value)
    {
        Console.Write(dic+" ");
    }
    Console.WriteLine();
}

// foreach (var bike in bikeBrand)
// {

//     Console.Write(bike.Key +" = ");
//     foreach (var myString in bike.Value)
//     {
//         Console.Write(myString+", ");
//     }
//     Console.WriteLine();
// }



// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Biodata bio1 = new Biodata("Name1");
//         Biodata bio2 = new Biodata("Name2");
//         Biodata bio3 = new Biodata("Name3");
//         Biodata bio4 = new Biodata("Name4");

//         Dictionary<int, Biodata> data = new Dictionary<int, Biodata>();
//         data.Add(001, bio1);
//         data.Add(002, bio2);
//         data.Add(003, bio3);
//         data.Add(004, bio4);

//         foreach (var anggota in data)
//         {
//             Console.WriteLine(anggota.Key + " - " + anggota.Value);
//         }
//         Console.WriteLine("Hello, World!");

//     }
//     class Biodata{
//         string? name;
//         public string Name {
//             get{
//                 return name = "Nama = "+name ;
//             }
//             set{
//                 name = value;
//             }
//         }
//         public Biodata(string name){
//             Name = name;
//         }
//     }
// }


// // internal class Program
// // {
// //     private static void Main(string[] args)
// //     {
// //         Biodata bio1 = new Biodata("Name1");
// //         Biodata bio2 = new Biodata("Name2");
// //         Biodata bio3 = new Biodata("Name3");
// //         Biodata bio4 = new Biodata("Name4");

// //         Dictionary<int, string> data = new Dictionary<int, string>();
// //         data.Add(001, "Name1");
// //         data.Add(002, "Name2");
// //         data.Add(003, "Name3");
// //         data.Add(004, "Name4");

// //         foreach (var anggota in data)
// //         {
// //             Console.WriteLine(anggota.Key + " - " + anggota.Value);
// //             Console.WriteLine(bio1.Name);
// //         }
// //         Console.WriteLine("Hello, World!");
// //                     Console.WriteLine(bio1.Name);

// //     }
// //     class Biodata{
// //         string? name;
// //         public string Name {
// //             get{
// //                 return name = "Nama = "+name ;
// //             }
// //             set{
// //                 name = value;
// //             }
// //         }
// //         public Biodata(string name){
// //             Name = name;
// //         }
// //     }
// // }