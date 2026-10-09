using Backend;

var list = new SinglyLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.WriteLine(list);
            break;
        default: 
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insert at beginning.");
    Console.WriteLine("2. Insert at end.");
    Console.WriteLine("3. Contains."); // Homework!
    Console.WriteLine("4. Remove."); // Homework!
    Console.WriteLine("5. Reverse."); // Homework!
    Console.WriteLine("6. Insert."); // Homework! ask for item to insert and ask for previous item
    Console.WriteLine("7. Order."); // Homework! order alphabetically
    Console.WriteLine("8. Show list.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option? ");
    return Console.ReadLine()!;
}