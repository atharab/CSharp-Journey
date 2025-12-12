// See https://aka.ms/new-console-template for more information
using System.Net.Security;

//Console.WriteLine("Hello\nWorld!");
//Console.WriteLine("Hello\tWorld!");
//Console.WriteLine("Hello \"World\"!");
//Console.WriteLine("c:\\source\\repos");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\") ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.Write("\nOutput Directory:\t"); 
// Console.Write(@"c:\invoices");

// Console.WriteLine(@"    c:\sources\repos
//       (this is where your code goes)");

// string firstName = "Bob";
// string greeting = "Hello";
// string message = $"{greeting} {firstName}!";
// Console.WriteLine(message);

// string firstName = "Bob";
// string message = $"Hello {firstName}!";
// Console.WriteLine(message);

// int version = 11;
// string updateText = "Update to Windows";
// string message = $"{updateText} {version}";
// Console.WriteLine($"{updateText} {version}");

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output: \n\t{englishLocation}");
Console.WriteLine($"\n{russianMessage}: \n\t{russianLocation}");
