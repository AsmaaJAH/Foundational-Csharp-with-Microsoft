//from here: https://github.com/afiqhafizuddin/cs-learn
/*
//1. value types:
//primative types:

//Signed integral
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Unsigned integral
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Floating point:
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//2. reference values with new keyword for objects from class, string ,and array:
int[] data;
data = new int[3];
//or: int[] data = new int[3];

*/
/*-----------------------------------------------------
-----------------------output:-------------------------
--------------------------------------------------------
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615

ulong  : 0 to 18446744073709551615
ulong  : 0 to 18446744073709551615

Floating point types:
float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
ulong  : 0 to 18446744073709551615

Floating point types:
float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)
*/
//====================================================================================
//------------------------------------------------------------------------------------
//====================================================================================
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/*
Output
1
2
*/
string name = "Bob";
Console.WriteLine(int.Parse(name));
// output:
// System.FormatException: 'Input string was not in a correct format.'


//----------------------------------------------------------

int value1 = 11;
decimal val = 6.2m;
float value3 = 4.3f;
double values=5.2;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

//-------------------------------------------------------------------------------------

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
//sorting an array:
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
//reversing the order of an array:
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Array.Clear() starting at index 0 and clearing 2 elements.:
Array.Clear(pallets, 0, 2);

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*output:
------------
Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13
*/
//--------------------------------------------------------------------------------------

//Call a string helper method on a cleared element
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*error output:
------------
System.NullReferenceException: Object reference not set to an instance of an object.
*/

//-------------------------------------------------------------------------
//resize to add and remove:
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
/*

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12
*/
//----------------------------------------------------------------------------------
//Combine all of the chars into a new comma-separated-value string using Join()
string value12 = "abc123";
char[] valueArray = value12.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray); //3,2,1,c,b,a
Console.WriteLine(result);
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
/*
3
2
1
c
b
a
*/
