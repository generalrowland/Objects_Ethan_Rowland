// See https://aka.ms/new-console-template for more information
using Objects_Ethan_Rowland;

Computer23 myComputer = new Computer23("Apple", "All-in-One", true);
IBootUp myBootUp = myComputer;
Console.WriteLine(myComputer.Equals(myBootUp));

Computer23 myOtherComputer = new Computer23("Apple", "All-in-One", true);
Console.WriteLine(myComputer.Equals(myOtherComputer));

string myString = myComputer.ToString();
string myOtherString = myString;

myString = "Hi!";

Console.WriteLine(myString);
Console.WriteLine(myOtherString);


Console.WriteLine(myString == myComputer.ToString());
Console.WriteLine(myString == myComputer.ToString());

Console.WriteLine(myComputer.GetType());
Console.WriteLine(myBootUp.GetType());

myOtherComputer.PowerOnOff();

Console.WriteLine(myString == myOtherComputer.ToString());
Console.WriteLine(myString);
Console.WriteLine(myOtherComputer.ToString());

Console.WriteLine(myString.Contains('i'));

Console.WriteLine(myString.ToUpper());