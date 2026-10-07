// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini

// Numbers can be made more readable using _ as a number separator

// This class are teaching you how to improve readbility of your code by using underscores in numeric literals.

int d = 123_456;
float f = 1234.5f;
var x = 0xABCDEF;
var b = 0b1101111010010010;

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");
