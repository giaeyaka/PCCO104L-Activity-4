using System;

class Program
{
    static void Main(string[] args)
    {
        int previousNumber = 0;
        string currentMessage = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }

            if (int.TryParse(userInput, out int number))
            {
                previousNumber += number;
                Console.WriteLine($"Adding {number} to {previousNumber - number} = {previousNumber}");
            }
            else
            {
                currentMessage += userInput;
                Console.WriteLine($"Current Message is: {currentMessage}");
            }
        }
    }
}