﻿Console.WriteLine("Are you coming or leavinf? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye(); 
}





static void PrintHello() //function ehk meetod
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}