Console.WriteLine("give me a number of seconds" );
string Question = Console.ReadLine();

int seconds = int.Parse(Question);

int numberOfDays = seconds / (24 * 3600);
int remainingSeconds = seconds % (24 * 3600);
int numberOfHours = remainingSeconds / 3600;
remainingSeconds %= 3600;
int numberOfMinutes = remainingSeconds / 60;
int numberOfSeconds = remainingSeconds % 60;

Console.WriteLine("Number of days " + numberOfDays);
Console.WriteLine("Number of hours " + numberOfHours);
Console.WriteLine("Number of minutes " + numberOfMinutes);
Console.WriteLine("Number of seconds " + numberOfSeconds);

Console.WriteLine($"{numberOfDays}.{numberOfHours}.{numberOfMinutes}.{numberOfSeconds}");

Console.WriteLine($"in total that is {(float)seconds / 86400}");


//* So code actually copied from Fredrik himself, my try on making the code
// *Question *
// int minutes;
//int hours;
//int days;

//int secondsV;
//int minutesV;
//int hoursV;
//int daysV;

// = Question % 60;
//minutes = SecondsV / 60;
// Etc... so it wasn't really working out but im happy with me trying.















