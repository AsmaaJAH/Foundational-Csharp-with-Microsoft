class Program
{
    static void Main()
    {

        // string initialString = "The quick brown fox jumps over the lazy dog.";
        
        // // convert the message into a char array
        // char[] charMessage = initialString.ToCharArray();
        
        // // foreach (char item in charMessage)
        // // {
        // //     Array.ForEach(charMessage,
        // //     item => Console.WriteLine(item));
        // // }


        // // Reverse the chars
        // Array.Reverse(charMessage);

        // int oLetterCounts = 0;
        // // count the o's
        // foreach (char index in charMessage)
        // {
        //     if (index == 'o')
        //     {
        //         oLetterCounts++;
        //     }
        // }

        // // convert it back to a string
        // string newMessage = new String(charMessage);

        // // print it out
        // Console.WriteLine(newMessage);
        // Console.WriteLine($"'o' appears {oLetterCounts} times.");
        /*
        -----------------------  Create readable code with conventions, whitespace, and comments in C# :


        //----------------- challenge activity for nested iteration and selection statements: 
        string[] fraudulentOrderIDs = [
        "B123",
        "C234",
        "A345",
        "C15",
        "B177",
        "G3003",
        "C235",
        "B179"
        ];
        foreach (string item in fraudulentOrderIDs)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine($"{item}");
            }
        }
        ------- arrays:
        // string[] fraudulentOrderIDs = new string[3];
        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";
        string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
        //fraudulentOrderIDs[3] = "D000"; The build will succees because the compiler was able to successfully parse and analyze your code without encountering any syntax errors or semantic errors.

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        ------for each:
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");

        //-----------------  Challenge: Improve renewal rate of subscriptions ---------------------------------
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        Console.WriteLine($"{daysUntilExpiration}");
        // Your code goes here:
        if (daysUntilExpiration == 12)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 11)
        {
            discountPercentage = 20;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");

        }

        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }

        --------------------------------------------------------------------------------

        Random dice= new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);
        //Console.Clear();


        //-----------------------------------
        int number = 7;
        string text = "seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text);


        //-----------------------------------

        int firstValue = 500;
        int secondValue = 600;
        int largerValue= Math.Max(firstValue,secondValue );
        Console.WriteLine(largerValue);
        //------------------------------------------------

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }

            Console.WriteLine($"Your total including the bonus: {total}");
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }
        ------------------------------------------

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }
        */
    }
}