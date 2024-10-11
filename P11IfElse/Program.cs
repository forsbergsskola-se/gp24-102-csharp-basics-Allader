Console.WriteLine("How Old are you??");

int age = int.Parse(Console.ReadLine());



if (age < 13){ //
    Console.WriteLine("You are young");

    
}else if (age < 18)
{
   Console.WriteLine("You are Teen");
}
else
{
    Console.WriteLine("You are Adult");
}
Console.WriteLine("Give me another Interger");

int wholeNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"The maximum is: {(age > wholeNumber ? age : wholeNumber)}.");

int greaterNumber = age > wholeNumber ? age : wholeNumber;

bool isEven = greaterNumber % 2 == 0; // 0 remainders == an even number.

Console.WriteLine($"That number is an {(isEven ? "even" : "odd")} number.");

//int wholeNumber = int.Parse(Console.ReadLine());

//if (age > wholeNumber)
//{
//    Console.WriteLine($"The Maximum is: {age}.");
//}
//else
//{
//    Console.WriteLine($"The Maximum is: {wholeNumber}.");
//}

//Ternry if - 

//string output = age > wholeNumber ? $"the maximum is : {age}.": $"The maximum is: {wholeNumber}.";

//Console.WriteLine(output);

//.WriteLine($"The maxium is : {(age > wholeNumber ? age : wholeNumber)}.");

//int greaterNumber = age > wholeNumber ? age : wholeNumber;

//bool isEven = greaterNumber % 2 == 0; //0 remainders == an even number

//Console.WriteLine($"That Number is an {(isEven ? "even" : "odd")}.number");
//for some reason i don't get why. Did not understand it. its prints out 3 times the maximum...

