// Calculate Annual Compound Interest A = P(1 + r/n)^nt

// A = Future value of the investment
// P = Principal amount
// r = Annual interest rate (decimal)
// n = Number of times interest is compounded per year
// t = Time in years
while (true)
{
    Console.WriteLine("*****Welcome To Compound Interest Calculator*****\n");

    // P = Principal amount
    Console.Write("Enter your amount of investment: ");
    double P = Convert.ToDouble(Console.ReadLine());

    // r = Annual interest rate (decimal)
    Console.Write("\n\nEnter annual interest rate percentage (%): ");
    double r = Convert.ToDouble(Console.ReadLine());
    r = r / 100;

    // n = Number of times interest is compounded per year
    Console.Write("\n\nEnter number of times interest compounded in a year: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // t = Time in years
    Console.Write("\n\nIn how many years you want to see you future value of invesment?: ");
    int t = Convert.ToInt32(Console.ReadLine());

    // A = Future value of the investment
    double A = Math.Round(P * Math.Pow((1 + (r / n)), (n * t)), 2, MidpointRounding.AwayFromZero);

    Console.WriteLine($"\n\nYour future value of the investment will be: {A}\n\n");
}

