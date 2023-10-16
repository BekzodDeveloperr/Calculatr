

Console.WriteLine("1. Add two numbers\r\n2. Add list of numbers");
int number = int.Parse(Console.ReadLine());

 if  (number == 1)
    {
    Console.Write("Enter first number: ");
    int number1 = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Resualt: {number1 + number2}");
    }
else if (number == 2)
    {

    Console.Write("Enter comma-separated (,) integer values: ");
    string l = Console.ReadLine();
    string[] lArray = l.Split(',');
    int sum = 0;

    foreach (string num in lArray)
        {
        if (int.TryParse(num, out int Number))
            {
                sum += Number;
            }
        else
            {
                Console.WriteLine($"Invalid input: {num} is not an integer.");
                return;
            }
        }
    Console.WriteLine($"Resualt: {sum}");

        }
    else
        {
            Console.WriteLine("Enter the number 1 or 2!");
        }