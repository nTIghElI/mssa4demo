// namespace Day_3;

// class Program
// {
//     static void Main(string[] args)
//     {

//         // //1. Declare variables (a string array called mStrings with multiple strings)
//         // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//         // //2. Loop through each string in the array
//         // foreach (string input in myStrings)
//         // {
//         //     //a. Store intermediate string
//         //     string myString = input;
//         //     //b. Use IndexOf() to find the first period in myString
//         //     int periodLocation = myString.IndexOf(".");
//         //     //3. While there is a period in myString
//         //     while (periodLocation != -1)
//         //     {
//         //         //a. Extract the sentence before the period
//         //         string sentence = myString.Remove(periodLocation);
//         //         //b. Display the sentence
//         //         Console.WriteLine(sentence);
//         //         //c. Remove the sentence and period from the original string
//         //         myString = myString.Substring(periodLocation + 1);
//         //         //d. Remove leading spaces with TrimStart
//         //         myString = myString.TrimStart();
//         //         //e. Find the next period using IndexOf
//         //         periodLocation = myString.IndexOf(".");
//         //     }
//         //     //4. If any text remains after the last period, display it.
//         //     Console.WriteLine(myString.Trim());



//         //1. Declare variables (a string array called mStrings with multiple strings)
//         string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
//         //2. Loop through each string in the array
//         foreach (string input in myStrings)
//         {
//             //a. Store intermediate string
//             string myString = input;
//             //b. Use Split() to find the first period in myString
//             string[] sentences = myString.Split(".");
//             foreach (string sentence in sentences)
//             {
//                 string trimmed = sentence.Trim();
//                 System.Console.WriteLine(trimmed);
//             }

//         }
//     }
// }

using System.Globalization;

// System.Console.WriteLine("Hello World");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// float sum = 0.0F;
// string letters;
// //create a loop
// foreach (string value in values)
// {
//     System.Console.WriteLine(value);
//     float.TryParse(value, out float numbers);
//     sum += numbers;

//     // string letters = values[].Concat(value);
//     letters += value;
//     System.Console.WriteLine($"Message: {value}");


// }
// System.Console.WriteLine($"Total{sum}");

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;
// Your code here to set result1
// string[] values = string.Join(value1, value2, value3);

// Hint: You need to round the result to nearest integer (don't just truncate)
// int.TryParse(value2, out int result);
// int result1 = result/ value1;
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
// // Your code here to set result2
// decimal result2 = (decimal)value3 / value2; 
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
// // Your code here to set result3
// float result3 = value1 / value3; //(float) isn't neccessary
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//  Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// //resize to non-null numbers

// System.Console.WriteLine("");
// string[] nonNullPallets;
// for (int i = 0; i < pallets.Length; i++)
// {
//     if (pallets[] != null)
//         nonNullPallets[] = pallet[]
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//  Console.WriteLine(item);
// }












