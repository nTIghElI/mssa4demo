// Console.WriteLine("Pick a number between 5 & 10");
// bool userIsValid = false;
// int? userInput = null;

// while (!userIsValid)
// {
//     do
//     {
//         string input = Console.ReadLine();
//         userInput = int.TryParse(input, out int result) ? result : null;

//         if (userInput <= 10 && userInput >= 5)
//         {
//             userIsValid = true;
//             Console.WriteLine($"Thank you you're number is {userInput}");
//         }
//         else
//         {
//             Console.WriteLine("Please pick a valid number between 5 & 10");
//         }
//     } while (!userIsValid);
// }

//Admin
// Console.WriteLine(@"Please input your role: ""Administrator"" ""Manager"" or ""User"" ");
// bool isValidRole = false;
// string userInput = "";

// while (!isValidRole)
// {
//     do
//     {
//         userInput = Console.ReadLine();
//         userInput = userInput.ToLower();
//         if (userInput == "administrator" || userInput == "admin")
//         {
//             isValidRole = true;
//             Console.WriteLine("Welcome, Admin!");
//         }
//         else if (userInput == "manager")
//         {
//             isValidRole = true;
//             Console.WriteLine("Welcome, Manager.");
//         }
//         else if (userInput == "user")
//         {
//             isValidRole = true;
//             Console.WriteLine("Welcome back, user!");
//         }
//         else
//         {
//             isValidRole = false;
//             Console.WriteLine(@"Please input your role: ""Administrator"" ""Manager"" or ""User"" ");
//         }
//     } while (!isValidRole);
// }

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string periodLocation = ".";
bool isValidPeriodLocation = false;
for (int i = 0; i < myStrings.Length; i++)
{
    while (!isValidPeriodLocation)
    {
        do
        {
            myStrings[i].IndexOf(".");

        } while (!isValidPeriodLocation);
    } i += i;
    if (i > myStrings.Length)
    {
        break;
    }
}


