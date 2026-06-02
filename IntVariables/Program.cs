

int age = 0; // even if it's not decalared, it will be initialized to 0 by default

age = 29;

int ageInTenYears = age + 10;


// +/- 2 billion is the range of int
// signed Int32 is what is used for int, 32 bits
// unsigned Int32 has range of 4 billion, Uint32
// bit - 0 or 1
// byte - 8 bits . 00000000
// 1 (1bit - 2 numbers), 11 (2bits - 4 numbers), 111 (3bits - 8 numbers), 1111 (4bits - 16 numbers) and so on
// in Int32 the first bit is used for the sign, that's why Uint32 has a bigger range

Console.WriteLine(age); // Behind the scenes, it will do age.ToString()
Console.WriteLine(ageInTenYears);

// Console.WriteLine(age / 2); // When you divide two integers, the result is also an integer so the result can be wrong. So don't divide ints

// App that asks you your name, then your age, and then tells you how old you will be in 10 years

Console.Write("Welcome! Please enter your name: "); // Asks user for their name
string name = string.Empty; // Creates an empty string to store the user's name
name = Console.ReadLine();  // Stores user's input in the name variable
Console.WriteLine();        // New line for better formatting
Console.Write("Please enter your age: "); // Asks user for their age
string userAgeString = string.Empty; // Creates an empty string to store the user's age
userAgeString = Console.ReadLine(); // Stores user's input in the userAgeString variable
int userAge = 0; // Creates integer to store user's age
userAge = int.Parse(userAgeString); // Converts the user's age from a string to an integer and stores it in the userAge variable.
int userAgeInTenYears = 0;  // Creates an integer to store the user's age in ten years
userAgeInTenYears = userAge + 10; // Calculates user's age in ten years
Console.WriteLine($"Hi {name}, you will be {userAgeInTenYears} in 10 years."); 