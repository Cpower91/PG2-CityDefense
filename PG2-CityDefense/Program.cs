// See https://aka.ms/new-console-template for more information
Console.Title = "The Defense of Consolas!";

Console.WriteLine("The city is under attack! Fireballs are being catapaulted into the city from a moving airship!\nThe city is arranged in blocks, like a chessboard. Use the prompts below to select a spot to protect.");
string c, r;
Console.WriteLine("Target Row?....");
r = Console.ReadLine();
int col, row;
int.TryParse(r, out row);