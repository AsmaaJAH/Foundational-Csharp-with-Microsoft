//Evaluate Boolean expressions to make decisions in C# 
// Random value= new Random();
// int currentNum=value.Next(1,2);
// Console.WriteLine(currentNum);
// string coin= currentNum==1? "head":"tail";
// Console.WriteLine(coin);

// string permission = "Admin|Manager";
// int level = 55;

string fruit = "apple";
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}

//Iterate through a code block using for statement in C# :
//for (initializer, condition, and iterator)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//FizzBuzz challenge.
//do-while and while 
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");



do
{
    current = random.Next(1, 11);

    if (current >= 8) continue; //the continue key word will transfer control to the end of the code block and the while will evaluate (current != 7).

    Console.WriteLine(current);
} while (current != 7);


//When using a Console.ReadLine() statement to obtain user input, it's common practice to use a nullable type string (designated string?) for the input variable and then evaluate the value entered by the user. 
/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);


// capture user input in a string variable named readResult
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue); //out=output
*/
//---------------------------------------------------------------------------------------------------
// Code project 2 - write code that validates string input
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine(); // to make pressing the enter give u an empty terminal project directory again  

//------------------------------------------------------------------------------------------
//Code project 3:-
// Write code that processes the contents of a string array:
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);
        //Console.WriteLine("herrrrrrrrrrrrrrrrrreeeeeeeeeee--->"+mySentence);//output: herrrrrrrrrrrrrrrrrreeeeeeeeeee--->I like pizza

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
