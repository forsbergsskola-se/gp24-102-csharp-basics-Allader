// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, There! I am Atom, your personal conversion unit on this computer! Give me a number");

string Question = Console.ReadLine();

Console.WriteLine(Question);

float Answer = float.Parse(Question);

float decimalNumber = Answer;
int number = (int) decimalNumber; // Changes float (decimalNumber) >  Integar (number) 

Console.WriteLine(number);

    

/*Create a Console Project named P8Conversion How To?
Ask the user for a Number and assign the result to a variable.
Convert the variable to Type float.
Print the float to the Console.
Convert the double number to type int.
Print the int to the console.
Convert the original string to type int.
What happens? (Hint: You will see an Invalid Format Exception
 */


//string input = Console.ReadLine();