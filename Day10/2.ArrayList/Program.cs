//arraylist dapat diisi berbagai jenis type data
//type data output itemnya adalah object
//memiliki bawaan add, remove, insert, dll


using System.Collections;
namespace ArrayListDemo;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add('a');
        arrayList.Add("Jhon");
        arrayList.Add(3);
        arrayList.Add(4.3);//double        arrayList.Add(5.7f);//float
        arrayList.Add(1.2M);//decimal
        arrayList.Add(null);
        arrayList.Add("mikei");
        arrayList.Add("");
        arrayList.Add(true);

        foreach (var item in arrayList)
        Console.WriteLine(item);

        // string firstItem = arrayList[1]; // ERROR: karena type data item adalah objek dan tidak bisa dicoversi secara implisit
        string secondItem = (string)arrayList[1]; // ATAU BISA DIKTULIS DENGAN NOTASI atstring secondItem = arrayList[1] as string;
        char firstItem = (char)arrayList[0];

        // double thirdItem = (double)arrayList[2];  // ERROR: arrayList[2] dideteksi sebagai int32 tidak bisa di cast sebagai double
        double thirdItem = (int)arrayList[2];
        
        Console.WriteLine("\n"+"\n"+firstItem);
        Console.WriteLine(secondItem);
        Console.WriteLine(thirdItem);

        var arrayList2 = new ArrayList()
			{
				102, "Smith", "Smith", true, 15.6
			};

			foreach (var item in arrayList2)
			{
				Console.WriteLine(item);
			}

    }
}