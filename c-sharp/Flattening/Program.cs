// See https://aka.ms/new-console-template for more information

using Flattening;

Console.WriteLine("Welcome to the Flattening app! This will flatten an arbitrarily nested array of strings.");

 object[] nested1 =
 [
     new object[] { "one", "Two", new object[] { "Three" }, },
    "Four"
 ];
 

var flat = Flattener.Flatten(nested1);
Console.WriteLine(string.Join(", ", flat));