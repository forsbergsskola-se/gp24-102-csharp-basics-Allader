// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let's Play a game! Guess the number 1 - 100 or ELSE!");

Random randomNr = new Random();
int randomNumber = randomNr.Next(1, 100);
int Guesses = 10;
int Question = int.Parse(Console.ReadLine());
bool Win = (Question == randomNumber);
while (int.TryParse(Console.ReadLine(), out Question))
{
    if (Question > randomNumber)
    {
        Console.WriteLine("You entered too high!");
    }
    else if (Question < randomNumber)
    {
        Console.WriteLine("You entered too low!");

    }
    else if (Question == randomNumber)
    {
        Console.WriteLine($"Congratulations! you guessed it! it was {randomNumber}");
    }
    
}

