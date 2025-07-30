// // // Console.WriteLine("Pick a number between 5 & 10");
// // // bool userIsValid = false;
// // // int? userInput = null;

// // // while (!userIsValid)
// // // {
// // //     do
// // //     {
// // //         string input = Console.ReadLine();
// // //         userInput = int.TryParse(input, out int result) ? result : null;

// // //         if (userInput <= 10 && userInput >= 5)
// // //         {
// // //             userIsValid = true;
// // //             Console.WriteLine($"Thank you you're number is {userInput}");
// // //         }
// // //         else
// // //         {
// // //             Console.WriteLine("Please pick a valid number between 5 & 10");
// // //         }
// // //     } while (!userIsValid);
// // // }

// // //Admin
// // // Console.WriteLine(@"Please input your role: ""Administrator"" ""Manager"" or ""User"" ");
// // // bool isValidRole = false;
// // // string userInput = "";

// // // while (!isValidRole)
// // // {
// // //     do
// // //     {
// // //         userInput = Console.ReadLine();
// // //         userInput = userInput.ToLower();
// // //         if (userInput == "administrator" || userInput == "admin")
// // //         {
// // //             isValidRole = true;
// // //             Console.WriteLine("Welcome, Admin!");
// // //         }
// // //         else if (userInput == "manager")
// // //         {
// // //             isValidRole = true;
// // //             Console.WriteLine("Welcome, Manager.");
// // //         }
// // //         else if (userInput == "user")
// // //         {
// // //             isValidRole = true;
// // //             Console.WriteLine("Welcome back, user!");
// // //         }
// // //         else
// // //         {
// // //             isValidRole = false;
// // //             Console.WriteLine(@"Please input your role: ""Administrator"" ""Manager"" or ""User"" ");
// // //         }
// // //     } while (!isValidRole);
// // // }

// // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// // int periodLocation = 0;
// // string? myString = "";
// // // int periodLocation = myStrings[i].IndexOf(".");
// // bool isValidPeriodLocation = false;
// // for (int i = 0; i < myStrings.Length; i++)
// // {
// //     myString = myStrings[i];
// //     for (int j = 0; j < myString.Length; j++)
// //         if (myString[j] == '.')
// //         {
// //             Console.Write($"{myString}");
// //             break;
// //             // periodLocation = myString.IndexOf('.');
// //             // Console.WriteLine($"{periodLocation}");
// //         }
        
// // }
// // System.Console.WriteLine("Loop finished");

// string[] sentance = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// foreach (string line in sentance)
// {
//     string periodLine = line;

//     while (periodLine.Contains('.'))
//     {
//         int periodLocation = periodLine.IndexOf('.');

//         string partSub = periodLine.Substring(0, periodLocation);
//         string partTrim = partSub.TrimStart();
//         System.Console.WriteLine($"{partTrim}");
//         periodLine = periodLine.Remove(0, periodLocation + 1);

//     }
//     Console.WriteLine($"{periodLine.Trim()}");
// }


// // string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// // int periodLocation = 0;
// // bool isValidPeriodLocation = false;
// // for (int i = 0; i < myStrings.Length; i++)
// // {
// //     while (!isValidPeriodLocation)
// //     {
// //         do
// //         {
// //             periodLocation += 1;
// //             if (myStrings[i] == ".")
// //             {
// //                 myStrings[i].IndexOf(".");
// //             }

// //         } while (!isValidPeriodLocation);
// //     }
// //     i += i;
// //     if (i > myStrings.Length)
// //     {
// //         break;
// //     }
// // }




// // do
// // {
// //     // display the top-level menu options
 
// //     Console.Clear();
 
// //     Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
// //     Console.WriteLine(" 1. List all of our current pet information");
// //     Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
// //     Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
// //     Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
// //     Console.WriteLine(" 5. Edit an animal’s age");
// //     Console.WriteLine(" 6. Edit an animal’s personality description");
// //     Console.WriteLine(" 7. Display all cats with a specified characteristic");
// //     Console.WriteLine(" 8. Display all dogs with a specified characteristic");
// //     Console.WriteLine();
// //     Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

