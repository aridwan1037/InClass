// interface  Iprogram{
//     // void addValue(int, int);
// }

// string name = null;
// bool a = name=="";
// bool b = name.Equals("");
// Console.WriteLine($"{a},{b}");

// string s1 = "hello";
// string s2 = "hello";
// string s3 = new(new char[] {'h', 'e', 'l', 'l', 'o'});
// // The following comparison returns true
// bool result1 = s1 == s2;
// // The following comparison also returns true
// bool result2 = s1.Equals(s2);
// // The following comparison returns false, because s3 refers to a different instance
// bool result3 = s1 == s3;
// // The following comparison returns true, because s3 has the same value as s1
// bool result4 = s1.Equals(s3);
// Console.WriteLine($"{result3}");

// string s = true.ToString(); // s = "True"
//         bool b = bool.Parse (s); // b = true
//         bool success = int.TryParse ("123", out int _);
//         Console.WriteLine(success); // True

// // int a=100;????
//         bool success2 = int.TryParse ("1", out 200);
//         Console.WriteLine(success2); // False

int thirty = Convert.ToInt32 ("1E", 16); // Parse in hexadecimal (30)
uint five = Convert.ToUInt32 ("101", 2); // Parse in binary (5)
Console.WriteLine($"{five},{thirty}");