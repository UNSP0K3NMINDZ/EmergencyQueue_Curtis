using EmergencyQueue_Curtis;
using System.Collections.Generic;
using System.ComponentModel.Design;

ConsoleKeyInfo input;
EmergencyRoom patients = new EmergencyRoom();
patients.Add("Mickey Mouse", 2);
patients.Add("Fred Flintstone", 1);
patients.Add("George Jetson", 2);
patients.Add("Barney Rubble", 3);
patients.Add("Johnny Quest", 1);

foreach (string patient in patients.List())
{
    Console.WriteLine(patient.ToString());
}

Menu();

do
{
    input = Console.ReadKey();
    if (input.Key == ConsoleKey.D1)
    {
        Console.Clear();
        string name;
        int priority;
        Console.Write("Enter Patient Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Priority (1-3): ");
        priority = int.Parse(Console.ReadLine());
        patients.Add(name, priority);
        Console.Clear();
        Console.WriteLine("Patient was ADDED.");
    }
    else if (input.Key == ConsoleKey.D2)
    {
        Console.Clear();
        patients.Remove();
        Console.WriteLine("Top patient was REMOVED.");
    }
    else if(input.Key == ConsoleKey.D3)
    {
        Console.Clear();
        foreach (string patient in patients.List())
        {
            Console.WriteLine(patient.ToString());
        }
    }
    else
    {
        Console.Clear();
    }
    Menu();
} while (input.Key != ConsoleKey.Escape);

static void Menu()
{
    Console.WriteLine("");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Remove");
    Console.WriteLine("3. List");
    Console.WriteLine("ESC. Exit");
}






























