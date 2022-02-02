// See https://aka.ms/new-console-template for more information


//A bit of Decoration:
Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "CompoundInterestApp";


//Variables for the Interest Rate, Principal and CI:
double principalValue;
double interestRate;
double numberOfYearsOfCompounding;
double time;
double Amount;
double onePlusROnN;
double nT;


//User Credentials
string userName;

Console.WriteLine("Hello User! What is your Name?");
userName = Console.ReadLine();
Console.WriteLine("Welcome, " + userName + ". This is the compound Interest App.\nHit Enter to Continue.");
Console.ReadKey();

Console.WriteLine("What is the Principal Value of the CI you want to calculate?");
principalValue = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("What is the Interest Rate of the CI you want to calculate?");
interestRate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Number of times you are compounding the interest?");
numberOfYearsOfCompounding = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("For How Long? (Time)");
time = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The Amount has been calculated. Hit enter to see the amount:");
Console.ReadKey();
onePlusROnN = (1+interestRate/numberOfYearsOfCompounding);
nT = numberOfYearsOfCompounding * time;
Amount = principalValue*(Math.Pow(onePlusROnN, nT));
Console.WriteLine(Amount);


