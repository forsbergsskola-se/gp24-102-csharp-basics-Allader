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

Console.WriteLine($"{numberOfDays}.{numberOfHours}:{numberOfMinutes}.{numberOfSeconds}");

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


//P0.1
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("Give me km/h to change to m/s : ");
int m;
int km = int.Parse(Console.ReadLine());

m = km * 1000 / 3600;
Console.WriteLine($"m/seconds: {m}");


//P09.2
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("Give me Minutes to change to Seconds: ");
int secondsValue;
int minutesValue = int.Parse(Console.ReadLine());

secondsValue = minutesValue * 60;

Console.WriteLine($"Here's the seconds: {secondsValue}");

//P09.3
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine("Give me 2 integars to divide on");
float output;
int int1 = int.Parse(Console.ReadLine());

int int2 = int.Parse(Console.ReadLine());

output = int1 / int2;

Console.WriteLine($"Here's the result: {output}");

//P09.4
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine("Give me 2 integars to divide on");
int output1;
int int3 = int.Parse(Console.ReadLine());

int int4 = int.Parse(Console.ReadLine());

output1 = int1 % int2;

Console.WriteLine($"Here's the result: {output1}");

//P09.05
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");


Console.WriteLine("Give me radius to get CircleArea : ");

float radius = float.Parse(Console.ReadLine());

double Area = (Math.PI * Math.Pow(radius, 2));

Console.WriteLine($"Your area is: {Area}");

//P09.06
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");


Console.WriteLine("Give me int: ");

int number = int.Parse(Console.ReadLine());

int negation = -number;
Console.WriteLine($"{negation}");
//P09.07
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("Give me 2 integars to multiply on");
int outputmul;
int mul1 = int.Parse(Console.ReadLine());

int mul2 = int.Parse(Console.ReadLine());

outputmul = mul1 * mul2;

Console.WriteLine($"Here's the result: {outputmul}");



//P09.08
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine("Let me count your bmi : ");
Console.WriteLine("Your Weight ? : ");

int weight = int.Parse(Console.ReadLine());
Console.WriteLine("Your Height ? : ");

float height = float.Parse(Console.ReadLine());
float bmi = weight / (height * height);
Console.WriteLine($"Your bmi is: {bmi}");

//P09.09
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

//c = a^2 + b^2

Console.WriteLine("Let me count your hypotheses : ");
Console.WriteLine("Give me A: ");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("Give me B: ");

int B = int.Parse(Console.ReadLine());

double C = Math.Sqrt(A * A + B * B);

Console.WriteLine($"Here's your Answer C is: {C}");


//P09.10
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

Console.WriteLine("Give me Seconds: ");
    
int SecondsV = int.Parse(Console.ReadLine());

int MinutesV = SecondsV / 60;
int RemainingSecondsV = SecondsV % 60;

Console.WriteLine($"Here's your Answer Minutes:{MinutesV}, Seconds: {RemainingSecondsV}");















