/* Task: Write a program that asks how many items have been purchased and determines if each item needs to be restocked. Ask the user how many of each item has been purchased, calculate the remaining stock, and then print whether or not it needs to be restocked.
 *Soda starts with 100 in stock and will need a restock at 40
 *Chips starts with 40 in stock and will need a restock at 20
 *Candy starts with 60 in stock and will need a restock at 40
 *Each item should have a variable that holds its current stock value and a variable that holds the restock value. 
 */

// Introduction message
Console.WriteLine("Welcome to the restocking tool.\n");

// Initial stock and restock quantity
int sodaStock = 100;
int sodaRestock = 40;
int chipsStock = 40;
int chipsRestock = 20;
int candyStock = 60;
int candyRestock = 40;

// Process for Soda
Console.WriteLine($"How many Sodas have been sold today? {sodaStock} are in stock");
int sodasSold = int.Parse(Console.ReadLine());
if (sodasSold <= sodaStock)
{
    sodaStock -= sodasSold;  // Calculate the remaining stock
    Console.WriteLine($"There are {sodaStock} Sodas left\n");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

// Process for Chips
Console.WriteLine($"How many Chips have been sold today? {chipsStock} are in stock");
int chipsSold = int.Parse(Console.ReadLine());

// Check if the input is valid
if (chipsSold <= chipsStock)
{
    chipsStock -= chipsSold;  // Calculate the remaining stock
    Console.WriteLine($"There are {chipsStock} Chips left\n");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

// Process for Candy
Console.WriteLine($"How many Candy have been sold today? {candyStock} are in stock");
int candySold = int.Parse(Console.ReadLine());

// Check if the input is valid
if (candySold <= candyStock)
{
    candyStock -= candySold;  // Calculate the remaining stock
    Console.WriteLine($"There are {candyStock} Candy left\n");
}
else
{
    Console.WriteLine("That value is too high. Stock not adjusted\n");
}

// Thank you message
Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");


// Check for restocking
if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Sodas need to be restocked.");
}
if (chipsStock <= chipsRestock)
{
    Console.WriteLine("Chips need to be restocked.");
}
if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked.");
}
// Goodbye message
Console.WriteLine("\nGoodbye!");