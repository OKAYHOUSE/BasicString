// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Basic String Processing");

//Program loop
bool runProgram = true;
while (runProgram)
{
    //Prompt user to enter a sentence.
    Console.Write("\nPlease enter a sentence! ");
    string sentence = Console.ReadLine().ToLower();

    //Split the sentence into individual words and display each word on its own line.
    string[] words = sentence.Split(" ");
    foreach (string w in words)
    {
        Console.WriteLine(w);
    }

    //Ask user to continue
    while (true)
    {
        Console.Write("Would you like to continue? y/n: ");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Goodbye.");
            runProgram = false;
            break;

        }
        else { Console.WriteLine("Invalid entry. Please try again."); }
    }
}
