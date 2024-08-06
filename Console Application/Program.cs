// Working With Numbers

// Declaring variables exercises

// Numbers of pizza shops
using System;

int pizzaShops = 578;

// Total of Employees
int totalEmployee = 2678;

// Revenue
double revenue = 234567.32;

// Console.WriteLine(pizzaShops);
// Console.WriteLine(totalEmployee);
// Console.WriteLine(revenue);








// Arithmetic Operation
// Addition, Substraction, Multiplication, Division
// Take note that operation INT with FLOAT/DOUBLE/DECIMAL data type will result in FLOAT/DOUBLE/DECIMAL data type
var myIntDivision = 5/3;
var myDoubleDivision = 5.0/3;
var myAdditionWithDouble = 4 + 6.0f;

// Console.WriteLine(myIntDivision);
// Console.WriteLine(myDoubleDivision);
// Console.WriteLine(myAdditionWithDouble);

// Order of operation
// Console.WriteLine(6 + 4 * 4);







// Codecademy Exercises Age Calculation on different planet

int userAge = 23;

double jupiterYears = 11.86;

double jupiterAge = userAge / jupiterYears;

double journeyToJupiter = 6.142466;

double newEarthAge = userAge + journeyToJupiter;

double newJupiterAge = newEarthAge / jupiterYears;

//Console.WriteLine(userAge);
//Console.WriteLine(jupiterAge);
//Console.WriteLine(newEarthAge);
//Console.WriteLine(newJupiterAge);





// Learn about operator shortcut

//int myInt = 1;
//Console.WriteLine(myInt);

//// myInt increment by 1
////myInt++;
////Console.WriteLine(myInt);

//// increase myInt by 4
//myInt += 4;
//Console.WriteLine(myInt);

//myInt += 5;
//Console.WriteLine(myInt);


// Two steps forwars, One step back

int steps = 0;

steps += 2;

steps -= 1;

//Console.WriteLine(steps);




// Working with modulo %, modulo return a remainder :- What is leftover when we divide a number by another number

int students = 18;

int groupSize = 5;

// Does group size go evenly into student?

//Console.WriteLine(students%groupSize);


// Using Built-In Method, determine which number is smaller

//Math.Abs();
//Math.Sqrt();
//Math.Floor();
//Math.Min();

int numberOne = 12932;
int numberTwo = -2828472;

double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
//double numberOneSqrt = Math.Sqrt(numberOne);

Console.WriteLine(numberOneSqrt);

double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

Console.WriteLine(numberTwoSqrt);

Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));