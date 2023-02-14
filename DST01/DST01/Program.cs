// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = "John  Anchit";
Console.WriteLine("This is " + name);
if(string.IsNullOrEmpty(name))
{
    Console.WriteLine("Empty");
}
else
{
    Console.WriteLine("Given string: " + name);
}
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Empty");
}
else
{
    Console.WriteLine("Given string: " + name);
}

