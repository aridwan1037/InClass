//String And Text Handling
// ToLower()
// ToUpper()
// IsControl()
// IsDigit()
// IsLetter()
// IsLower()
// IsNumber()
// IsPunctuation()
// IsSeparator()
// IsUpper()
// IsWhiteSpace()
// Parse(string)
// ToString()

internal static class Program
{
    private static void Main(string[] args)
    {
        // string a = "Hello, world!";
        // Console.WriteLine("Original Text : "+a);

        // //ToUpper
        // string b = a.ToUpper();
        // Console.WriteLine(".ToUpper() : " + b);

        // // ToLower
        // string c = a.ToLower();
        // Console.WriteLine(".ToLower() : " + c);

        //IsControl
        // char d = Convert.ToChar(U0001);
        // bool e = char.IsControl(d);
        // Console.WriteLine(".IsControl() : " + e);

        //Constructing String
        //Mengubah char array menjadi string
        // char[] text = "Jumping Fox".ToArray();
        // string s = new string(text);
        // Console.WriteLine(".Constructing String : " + s);

        // string Empty = string.Empty;
        // string empty = "";
        // Console.WriteLine(empty.Equals("")); // True
        // Console.WriteLine(empty == Empty); // True
        // Console.WriteLine(empty.Length == 0); // True

        // Console.WriteLine ("quick brown fox".EndsWith ("fox")); // True
        // Console.WriteLine ("quick brown fox".Contains ("brown")); // True
        // string input = " quick brown fox ";
        // string trimmedInput = input.Trim(); // "quick brown fox"
        // string paddedInput = input.PadRight(20, '*'); // " quick brown fox ***"
        // string replacedInput = input.Replace(" ", "|"); // "| | |quick|brown|fox| | "
        // string uppercaseInput = input.ToUpperInvariant(); // " QUICK BROWN FOX "
        // string lowercaseInput = input.ToLower(); // " quick brown fox "
        // string substringInput = input.Substring(5, 10); // "brown fox"

        // Console.WriteLine("abcd ef,".IndexOfAny(new char[] { ' ', ',' })); // 2
        // Console.Write("pas5w0rd".IndexOfAny("012a3456789".ToCharArray())); // 3

        string[] words = "The quick brown fox".Split();
        // foreach (string word in words)
        //     Console.Write(word + "|"); // The|quick|brown|fox|
        string together = string.Join(" ", words); // The quick brown fox
        string sentence = string.Concat("The", "  quick", " brown", " fox");
        Console.WriteLine(sentence); // 1
                                     // The minimum width is useful for aligning columns. If the value is negative, the data is left-aligned; otherwise, it’s right-aligned:
        string composite = "Name={0,-20} Credit Limit={1,15:C}";
        Console.WriteLine(string.Format(composite, "Mary", 500));
        Console.WriteLine(string.Format(composite, "Gold D. mert Elizabeth", 20000));
    }
}

