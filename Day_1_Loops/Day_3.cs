// class Program
// {
//     static void Main(string[] args)
//     {
 
//         // 1. declare variables
//         bool isValid = false;
//         string? userInput;
//         string readResult = "";
//         // 2. dislay the role prompt
//         Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//         // 3. Start a do-while loop
//         do
//         {
//             // a. read input from a user
//             userInput = Console.ReadLine();
//             if (userInput != null)
//             {
//                 // b. trim and convert to a consistent case
//                 readResult = userInput.Trim().ToLower();
//                 // c. Check if the input matches one of 3 predefined values
//                 if (readResult == "administrator" || readResult == "manager" || readResult == "user")
//                 {
//                     // d. If there is a match - exit the loop
//                     isValid = true;
//                 }
//                 // e. Otherwise, display an error message
//                 else
//                 {
//                     Console.WriteLine($"The role name you entered {userInput} is not valid. Try again");
 
//                 }
//             }
//         } while (!isValid);
//         // 4. after the loop, show acceptance message
//         Console.WriteLine($"Your input value {readResult} has been accepted");
 
//         }
// }