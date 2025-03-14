// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type 2 Numbers");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
Console.WriteLine(Number1 * Number2);

Console.WriteLine("Enter Your Name");
string Name = Console.ReadLine();
Console.WriteLine($"Hello {Name}! It is nice to meet you! How was it to live with the Dinosaurs?");
Console.WriteLine("Answer the Question with Good or Bad");
string Answer = Console.ReadLine();
if (Answer == "Good")
{
    Console.WriteLine("Thats Good to Hear! >:)");
}
else if (Answer == "Bad")
{
    Console.WriteLine("Don't Lie to Me!");
}
