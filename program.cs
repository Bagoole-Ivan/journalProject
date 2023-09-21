using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write a new line");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._prompt = GetRandomPrompt();
                Console.WriteLine(newEntry._prompt);
                newEntry._response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                journal._entries.Add(newEntry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                journal._filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                journal._filename = Console.ReadLine();
                journal.SaveFile();
            }
            else if (choice == 5)
            {
                break;
            }
        }
        static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What have I achieved today?",
            "What should I have done better today?",
            "What was my filling about my connection with God today?",
            "Did I accomplish what I wanted to accomplish?",
            "This is my testimony today."
        };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    }


    }