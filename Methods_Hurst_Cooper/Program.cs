// See https://aka.ms/new-console-template for more information

//This Calls the Methods
{
    Numbers();
    EnterName();
}

//This asks for 2 numbers and multiplies them together
static void Numbers()
{
    Console.WriteLine("Type 2 Numbers");
    int Number1 = int.Parse(Console.ReadLine());
    int Number2 = int.Parse(Console.ReadLine());
    Console.WriteLine(Number1 * Number2);
}

//this asks for your name and prints the statment with your name
static void EnterName()
{
Console.WriteLine("Enter Your Name");
string Name = Console.ReadLine();
Console.WriteLine($"Hello {Name}! It is nice to meet you!");
Console.WriteLine("Have a fantastic day");
}



