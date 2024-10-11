using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Give me a seed number");

int Seed = int.Parse(Console.ReadLine());

Random random = new Random(Seed);

Console.WriteLine(Seed);

int number1 = random.Next(0, 5);
int number2 = random.Next(0, 5);
int number3 = random.Next(0, 5);

Console.WriteLine(number1);
Console.WriteLine(number2);
Console.WriteLine(number3);

//Double


double number4 = random.NextDouble()*0.5;
double number5 = random.NextDouble()*0.5;
double number6 = random.NextDouble()*0.5;

Console.WriteLine(number4);
Console.WriteLine(number5);
Console.WriteLine(number6);

double number7 = random.NextDouble()*(0.7 - 0.2) + 0.2;
double number8 = random.NextDouble()*(0.7 - 0.2) + 0.2;
double number9 = random.NextDouble()*(0.7 - 0.2) + 0.2;


Console.WriteLine(number7);
Console.WriteLine(number8);
Console.WriteLine(number9);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)\n");
float critChance = float.Parse(Console.ReadLine());

double chance = critChance;

double roll = Random.Shared.NextDouble();

bool success = roll < chance;

for (int i = 0; i < 5; i++)
{
 if(random.NextDouble() < critChance){
     
     Console.WriteLine("you were successful!");
 } else {
     Console.WriteLine("Unfortunately:(");
 }   
}












//Password Generator

Console.WriteLine("Random Password generator...");

string chars = "!#@#$%^&*()=0qwertyuiopasdfghjklzxcvbnm0123456789";

Random randomV = new Random();
string password = String.Empty;

for (int i = 0; i < 6; i++)
{
    password += chars[randomV.Next(chars.Length)];
    
}
Console.WriteLine($"Your new password is : {password}");

string gotoPassword = String.Empty;

backtrack:

gotoPassword += chars[randomV.Next(chars.Length)];

if (gotoPassword.Length < 6)
{
    goto backtrack;
}

Console.WriteLine($"Your new password is : {gotoPassword}");