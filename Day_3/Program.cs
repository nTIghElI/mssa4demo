namespace Day_3;

class Program
{
    static void Main(string[] args)
    {
 
        //1. Declare variables (a string array called mStrings with multiple strings)
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        //2. Loop through each string in the array
        foreach (string input in myStrings)
        {
            //a. Store intermediate string
            string myString = input;
            //b. Use IndexOf() to find the first period in myString
            int periodLocation = myString.IndexOf(".");
            //3. While there is a period in myString
            while (periodLocation != -1)
            {
                //a. Extract the sentence before the period
                string sentence = myString.Remove(periodLocation);
                //b. Display the sentence
                Console.WriteLine(sentence);
                //c. Remove the sentence and period from the original string
                myString = myString.Substring(periodLocation + 1);
                //d. Remove leading spaces with TrimStart
                myString = myString.TrimStart();
                //e. Find the next period using IndexOf
                periodLocation = myString.IndexOf(".");
            }
            //4. If any text remains after the last period, display it.
            Console.WriteLine(myString.Trim());
        }
    }
}
