using System;

class Program
{
    static void Main()
    {
        // Each item has a stock variable and a restock variable
        int sodaStock = 100;
        int sodaRestockValue = 40;

        int chipsStock = 40;
        int chipsRestockValue = 20;

        int candyStock = 60;
        int candyRestockValue = 40;

        // Display welcome message
        Console.WriteLine("Welcome to the restocking tool.");

        // Adjust Soda's stock based on user input
        AdjustStock("Sodas", ref sodaStock);

        // Adjust Chips' stock based on user input
        AdjustStock("Chips", ref chipsStock);

        // Adjust Candy's stock based on user input
        AdjustStock("Candy", ref candyStock);

        // Display restocking needs
        Console.WriteLine(" Thank you for filling out the values. Here’s what needs to be restocked.");
        CheckRestockStatus("Chips", chipsStock, chipsRestockValue);

        // Display goodbye message
        Console.WriteLine("Goodbye!");
    }

    // Method to adjust stock based on user input
    static void AdjustStock(string itemName, ref int stock)
    {
        Console.Write("How many " + itemName + " have been sold today? " + stock + " are in stock. ");
        if (int.TryParse(Console.ReadLine(), out int soldQuantity))
        {
            // If the user enters a number higher than the current item’s stock, don’t adjust the stock number
            if (soldQuantity <= stock)
            {
                stock -= soldQuantity;

                // Display remaining stock of the current item
                Console.WriteLine("There are " + stock + itemName + " left");
            }
            else
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    // Method to check restock status for each item independently
    static void CheckRestockStatus(string itemName, int remainingStock, int restockValue)
    {
        // Check if stock is less than or equal to restock
        if (remainingStock <= restockValue)
        {
            // Items that need to be restocked display on the console
            Console.WriteLine(itemName + " needs to be restocked");
        }
    }
}


