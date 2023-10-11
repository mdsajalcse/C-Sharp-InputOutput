//Basic input output in Csharp
Console.WriteLine("Hello, CSharp");
Console.Write("hello ");
Console.Write("World");
Console.WriteLine();

string name = "sajal";
string location = "Dhaka";
string name2 = "Rajib";
string location2 = "UK";
Console.WriteLine("Hello, {0}. You are from {1}",name,location);
Console.WriteLine("Hello, {0}.You are from {1}", name2, location2);

string text = $"hello {name}. You are from {location}";
Console.WriteLine(text);

string text2 = $"Hi! {name}. I'm from {location}";
Console.WriteLine (text2);

string whatAboutYou = "Fine";
string howOldAreYou = "28";
string areYouGraduate = "yes";
string whichCountryLiveIn = "England";

Console.WriteLine("How Are You {0}. How Old Are You {1}. Are You Gradudate {2}. Which Country Are you from {3}", whatAboutYou, howOldAreYou, areYouGraduate, whichCountryLiveIn);

string lifeStatus = $"How are You {whatAboutYou}.How old are you {howOldAreYou}.Are you graduate {areYouGraduate}. Which Country are you from {whichCountryLiveIn}";
Console.WriteLine(lifeStatus);

Console.WriteLine($"How are You {whatAboutYou}.How old are you {howOldAreYou}.Are you graduate {areYouGraduate}. Which Country are you from {whichCountryLiveIn}");

//input in csharp*/

//how to read value

string multiLine = Console.ReadLine();
int ascci = Console.Read();
ConsoleKeyInfo key=Console.ReadKey();
Console.WriteLine((char)ascci);
