
Console.Title = "The Defense of Consolas!";

Console.WriteLine("The city is under attack! Fireballs are being catapaulted into the city from a moving airship!\nThe city is arranged in blocks, like a chessboard. Use the prompts below to select a spot to protect.");
string c, r;
bool checkNum = false;
int col, row, value;
Console.WriteLine("Target Row?....");
r = Console.ReadLine();


if (r != null)
{
    int.TryParse(r, out row);
    if (row!=0)
    {
        Console.WriteLine($"Row {row} chosen.");
    }
    else
    {
        Console.WriteLine("Row must be a number.");
    };
}


if (int.TryParse(r, out value) && value>=1 && value<=50)
{
    int.TryParse(r, out row);
}
else
{
    Console.WriteLine("Row must be a number between 1 and 50");
}
Console.WriteLine("Target Column?....");
c = Console.ReadLine();
if (c != null)
{
    int.TryParse(c, out col);
    if (col != 0)
    {
        Console.WriteLine($"Column {col} chosen.");
    }
    else
    { 
        Console.WriteLine("Column must be a number.");
    };
}
int.TryParse(c, out col);
Console.WriteLine(col);