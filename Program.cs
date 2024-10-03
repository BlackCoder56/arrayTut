/*
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/

// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"\nThere are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Looping through an array using foreach

// int[] inventory = [ 200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach(int item in inventory)
// {
//     sum += item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");


// Array challenge

string[] fraudulentOrderIDs = ["B123", "C234","B144", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string checkedID in fraudulentOrderIDs)
{
    if(checkedID.StartsWith('B'))
    {
        Console.WriteLine($"{checkedID}");
    }
}