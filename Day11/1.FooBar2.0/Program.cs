using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Functions functions = new();

        functions.Add(3, "foo");
        functions.Add(4, "woo");
        functions.Add(5, "bar");
        functions.Add(7, "baz");

        functions.Remove(4);

        Console.Write("Please Enter a Number of Limit : ");
        int lim = Convert.ToInt32(Console.ReadLine());
        functions.SetLimit(lim);

        functions.Execute();
        functions.Print();
    }
}
class Functions
{
    public int _limit;
    public SortedList<int, string> _listKey = new SortedList<int, string>();

    public ArrayList _Numbers = new ArrayList();
    public void Add(int num, string value)
    {
        _listKey.Add(num, value);
        Console.WriteLine("berhasil ditambahkan : " + num + " " + value);
    }
    public void Remove(int num)
    {
        _listKey.Remove(num);
        Console.WriteLine("berhasil dihapus key : " + num);
    }
    public void SetLimit(int limit)
    {
        // if (limit is int limits)
        // {
            _limit = limit;
        // }
        // else
        // {
        //     Console.WriteLine("Please insert a number");
        //     break;
        // }

    }
    public void Execute()
    {
        for (int i = 0; i <= _limit; i++)
        {
            if (i == 0)
            {
                _Numbers.Add(i.ToString());
            }
            else
            {
                _Numbers.Add(Compare(i));
            }
        }
    }
    //method Compare untuk membandingkan dengan Key Value yang disimpan di Dictionary
    public string Compare(int x)
    {
        string result = "";
        foreach (KeyValuePair<int, string> kvp in _listKey)
        {
            if (x % kvp.Key == 0)
            {
                result += kvp.Value;
            }
        }
        return result == string.Empty ? x.ToString() : result;
    }
    public void Print()
    {
        foreach (var item in _listKey)
        {
            Console.WriteLine($" Kode yang tersimpan adalah Key {item.Key}, dan value {item.Value}");
        }
        foreach (var item in _Numbers)
        {
            Console.Write(item + "\t");
        }
    }
}