// // Data Type and Variable

// // Character Data Type
// // Notice that single quotation mark is used indicate that char data type
// Console.WriteLine('b');

// // double quotation mark for string data type
// Console.WriteLine("bus");

// // Error because single quote for char data type
// Console.WriteLine('Hello World!');

// // INT data type
// Console.WriteLine(123);

// // Float data type
// Console.WriteLine(0.25F);

// // Double data type (default)
// Console.WriteLine(2.625);

// // Decimal data type
// Console.WriteLine(12.39816M);

// // Boolean data type
// Console.WriteLine(true);
// Console.WriteLine(false);







// // Declaring Variable

// char userOption;
// int gameScore;
// decimal particlesPerMillion;
// bool processedCustomer;

// // Improper way to declare the variable
// string myName;
// "Maria" = myName;

// // Improperly assign value of the incorrect data type
// int myName;
// myName = "Hanzo";

// string firstName;
// firstName = "Rob";
// Console.WriteLine(firstName);

// // Reassign the firstName value
// firstName = "Maria";
// Console.WriteLine(firstName);

// firstName = "Dan";
// Console.WriteLine(firstName);

// firstName = "Oni";
// Console.WriteLine(firstName);

// // Error because variable not declare
// string firstName;
// Console.WriteLine(firstName);

// // Initializing the variable
// string firstName = "Bobby";
// Console.WriteLine(firstName);

// // Implicitly typed local variable - 'var' type
// var myName = "Young";
// var myAge = 23;
// var testOperation = myName + myAge;
// Console.WriteLine(myName);
// Console.WriteLine(myAge);
// Console.WriteLine(testOperation);

// var myInitial = 0.23432423423423423;
// Console.WriteLine(myInitial);




// // Code challenge from MS Learn
// string myName = "Bob";
// int myAge = 3;
// double myTemperature = 34.4;

// //Console.WriteLine($"Hello, {myName}! You have {myAge} messages in your inbox. The temperature is {myTemperature} celcius.");

// Console.Write("Hello, ");
// Console.Write(myName);
// Console.Write("! You have ");
// Console.Write(myAge);
// Console.Write(" messages in your inbox. The Temperature is ");
// Console.Write(myTemperature);
// Console.Write(" celcius.");





// Converting Data Type

// int myInt = 5;
// double myDouble = myInt;

// Console.WriteLine(myDouble);

// string myString = "354dsfs";
// int myInt = Convert.ToInt32(myString);

// Console.WriteLine(myInt);

decimal myDecimal = 3.142m;