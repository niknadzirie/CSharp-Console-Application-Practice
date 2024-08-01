// Creating To Do Application on Console

// Welcome message
Console.WriteLine("***** Welcome To To-Do Application! *****\n");

// Main menu
Console.WriteLine("Main Menu: \n");
Console.WriteLine("1. View Existed To-Do List");
Console.WriteLine("2. Add New To-Do List");
Console.WriteLine("3. Update To-Do List");
Console.WriteLine("4. Delete To-Do List\n");

// Wait for user to select the menu
Console.Write("Enter Menu Number: ");
string userOption = Console.ReadLine();

Console.Write("\nYou have select: ");
Console.WriteLine(userOption);