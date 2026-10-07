// LinkedIn Learning Course exercise file for Advanced C# Programming by Joe Marini
// Example file for the null coalescing operator

// A common scenario is to test a value for null and assign one if it is
// void OldSchoolLogString(string? theString) {
//     if (theString == null) {
//         Console.WriteLine("No string given!");
//     }
//     else {
//         Console.WriteLine(theString);
//     }
// }

// OldSchoolLogString("Test String");
// OldSchoolLogString(null);

// the ?? operator returns the left-hand value if not null, or the right one if it is null
// void LogString(string? TheString) {
//     Console.WriteLine(TheString ?? "No string given!");
// }

// LogString("Test String");
// LogString(null);

// It's also allowable to throw an exception as part of the right-hand expression
void ThrowableLogString(string? TheString) {
    Console.WriteLine(TheString ?? throw new ArgumentNullException(nameof(TheString), "Cannot be null!"));
}

ThrowableLogString("Test String");
ThrowableLogString(null);

// The ??= assigns a value if the left-hand value is null
string? Str = "Some other value";
Str ??= "Default Value";
Console.WriteLine(Str);