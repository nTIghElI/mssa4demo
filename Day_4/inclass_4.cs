// // string pangram = "The quick brown fox jumps over the lazy dog";
// // // string reversePangram = pangram.Reverse();
// // string[] splitPangram = pangram.Split(" ");
// // foreach (string word in splitPangram)
// // {
// //     System.Console.WriteLine(word);
// //     // char reverseWord = word.ToCharArray(pangram).Reverse();
// //     char reverseWord = 
// //     System.Console.WriteLine(reverseWord);
// // }

// // string pangram = "The quick brown fox jumps over the lazy dog";
// // string[] words = pangram.Split(" ");

// // string[] newWords = new string[words.Length];

// // for (int i = 0; i < words.Length; i++)
// // {
// //     char[] letters = words[i].ToCharArray();
// //     Array.Reverse(letters);
// //     newWords[i] = new string(letters);

// // }
// // string result = String.Join(" ", newWords);
// // System.Console.WriteLine(result);

// // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// // string[] splitStream = orderStream.Split(",");
// // for (int i = 0; i < splitStream.Length; i++) //foreach (string order in splitStream)
// // {
// //     // System.Console.WriteLine(splitStream[i]);
// //     string orderID = splitStream[i];
// //     // System.Console.WriteLine(orderID);
// //     if (orderID.Length != 4)
// //     {
// //         orderID = orderID + "-Error";
// //         System.Console.WriteLine(orderID);
// //     }
// //     else //string.TryParse(orderID, out _)
// //     {
// //         string orderNumber = orderID.Substring(1);
// //         if (int.TryParse(orderNumber, out _)) ;
// //         {

// //         }

// //     }

// // }

// // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// // string[] orders = orderStream.Split(",");
// // Array.Sort(orders);
// // foreach (string order in orders)
// // {
// //     if (order.Length != 4)
// //     {
// //         Console.WriteLine($"{order}- Error");
// //     }
// //     else
// //     {
// //         Console.WriteLine(order);
// //     }
// // }

// public class CustomClass
// {
//     private string privateName;
//     public double CalculatedKey { get; private set; }
//     public string PublicName { get; set; }
//     public CustomClass(string publicN, string privateN)
//     {
//         PublicName = publicN;
//         privateName = privateN;
//         CalculatedKey = InternalCalcuation();
//     }

//     private double InternalCalcuation()
//     {
//         return Math.PI * DateTime.Now.Ticks;
//     }
// }

// public class CustomBaseClass
// {
//     protected string name;
//     protected string lastname;
//     public CustomBaseClass(string name, string lastname)
//     {
//         this.name = name;
//         this.lastname = lastname;
//     }
// }

// public class CustomClass : CustomBaseClass
// {
//     public CustomClass() : base("John", "Doe")
//     {

//     }
// }