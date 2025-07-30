// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

//Adding loop for exit
while (menuSelection != "exit")
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        //list all pets with info
        case "1":
            System.Console.WriteLine("List of all our current pet friends:\n");
            for (int i = 0; i < maxPets; i++)
            {
                if (!string.IsNullOrWhiteSpace(ourAnimals[i, 0]))
                {
                    for (int j = 0; j < ourAnimals.GetLength(1); j++)
                    {
                        System.Console.WriteLine(ourAnimals[i, j]);
                    } 
                    System.Console.WriteLine();   
                }
            }
            break;

        // add new pet
        case "2":
        Console.WriteLine("Add a new animal friend to the ourAnimals array\n");

        int petCount = 0;
        for (int i = 0; i < maxPets; i++)
        {
            if (!string.IsNullOrWhiteSpace(ourAnimals[i, 0]))
                petCount++;
        }
        Console.WriteLine($"We currently have {petCount} pets. We can add {maxPets - petCount} more.");

        bool added = false;
        for (int i = 0; i < maxPets; i++)
        {
            if (string.IsNullOrWhiteSpace(ourAnimals[i, 0]))
            {
                bool validEntry = false;
                do
                {
                    Console.WriteLine("Enter species (dog or cat):");
                    string? inputSpecies = Console.ReadLine()?.ToLower();
                    if (inputSpecies == "dog" || inputSpecies == "cat")
                    {
                        animalSpecies = inputSpecies;
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter 'dog' or 'cat'.");
                    }
                } while (!validEntry);

                // Auto-generate ID
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                Console.WriteLine($"Assigned Pet ID: {animalID}");

                validEntry = false;
                    do
                    {
                        Console.WriteLine("Enter the pet's age or ? if unknown:");
                        string? ageInput = Console.ReadLine();
                        if (ageInput != null)
                        {
                            animalAge = ageInput;
                            if (animalAge == "?")
                            {
                                validEntry = true;
                            }
                            else
                            {
                                validEntry = int.TryParse(animalAge, out int result);
                                if (!validEntry)
                                {
                                    Console.WriteLine("Please enter a valid integer age or ?.");
                                }
                            }
                        }
                    } while (!validEntry);


                // For each optional input, do:
                Console.WriteLine("Enter nickname (or press Enter to skip):");
                string? nickInput = Console.ReadLine();
                animalNickname = string.IsNullOrWhiteSpace(nickInput) ? "tbd" : nickInput.ToLower();

                Console.WriteLine("Enter physical description (or press Enter to skip):");
                string? physInput = Console.ReadLine();
                animalPhysicalDescription = string.IsNullOrWhiteSpace(physInput) ? "tbd" : physInput.ToLower();

                Console.WriteLine("Enter personality (or press Enter to skip):");
                string? persInput = Console.ReadLine();
                animalPersonalityDescription = string.IsNullOrWhiteSpace(persInput) ? "tbd" : persInput.ToLower();


                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                added = true;
                break;
            }
        }

        if (!added)
        {
            Console.WriteLine("Sorry, we can't add more pets right now.");
        }
        break;

        //case x,y,z
        default:
            if (menuSelection != "exit")
            {
                System.Console.WriteLine("Invalid selection. Please enter 1-8 or type 'exit'");
            }
            break;
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    Console.ReadLine();
}
