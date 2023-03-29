// Formatting : **convert to String**.
// Parsing : **convert from a String**.

// string s = true.ToString(); // s = "True"
// bool b = bool.Parse (s); // b = true
// bool success = int.TryParse ("a", out int _);
// Console.WriteLine (success);


// NumberFormatInfo f = new NumberFormatInfo();
// f.CurrencySymbol = "$$";
// Console.WriteLine (3.ToString ("C", f)); // $$ 3.00
// // ------- //
// int value = 123456;
// string template = "The value is {0:C}.";
// string result = string.Format(new CultureInfo("en-US"), template, value);
// Console.WriteLine(result); //"The value is $123,456.00."

string composite = "Credit={0:C}";
Console.WriteLine(string.Format (composite, 500)); // Credit=$500.00
