
//Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);//Hello World!
Console.WriteLine(result);

// currency :c
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/*
With composite formatting, you use a string template containing one or more 
replacement tokens in the form {0}. 
You also supply a list of arguments that are matched with
the replacement tokens based on their order.
Composite formatting works when using string.Format() or Console.WriteLine().
*/

decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);
//------------------------------------------------------------------------------
//Measurement: 123,456.79 units
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
//Measurement: 123,456.7891 units
Console.WriteLine($"Measurement: {measurement:N4} units");


//------------------------------------------------------------------------------
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
/*Invoice Number: 1201
   Shares: 25.457 Product
     Sub Total: $2,750.00
           Tax: 15.83%
     Total Billed: $3,185.19*/
//------------------------------------------------------------------------------
 string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
/*
----Pad this
 Pad this----
*/

