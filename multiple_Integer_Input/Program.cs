//C# Multiple integer Value input

var line = Console.ReadLine();
var data = line.Split(' ');
var i1 = int.Parse(data[0]); //first integer
var i2 = int.Parse(data[1]); //second integer

int sum = i1 + i2;
Console.WriteLine(sum);
