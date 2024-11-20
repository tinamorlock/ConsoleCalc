// Console calculator program
// for practicing fundamentals

// Methods for calculator functions

static void Addition(int x, int y)
{
    Console.WriteLine($"\n{x} + {y} = {x+y}\n");
}

static void Subtraction(int x, int y)
{
    Console.WriteLine($"\n{x} - {y} = {x-y}\n");
}

static void Division(int x, int y)
{
    Console.WriteLine($"\n{x} / {y} = {x/y}\n");
}

static void Multiplication(int x, int y)
{
    Console.WriteLine($"\n{x} * {y} = {x*y}\n");
}

static void Remainder(int x, int y)
{
    int remainder = x % y;
    if (remainder > 0)
    {
        Console.WriteLine($"\nThe remainder is {remainder}.\n");
    } else { Console.WriteLine("\nThere is no remainder.\n");}
}

// Display of calculator menu

static bool Menu()
{
    int numOne = 0;
    int numTwo = 0;
    int choice = 0;
    bool menuLoop = true; 
    // gets calculator function
    Console.WriteLine("Welcome to the Console Calc!\n");
    Console.WriteLine("Addition — 1");
    Console.WriteLine("Subtraction — 2");
    Console.WriteLine("Division — 3");
    Console.WriteLine("Multiplication — 4");
    Console.WriteLine("Find the Remainder — 5");
    Console.WriteLine("Exit Console Calc — 0");
    Console.Write("Enter a menu selection: ");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice > 0)
    {
        // records the numbers
        Console.Write("Enter the first number: ");
        numOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        numTwo = Convert.ToInt32(Console.ReadLine());
    }
    // decides where to send based on menu choice
    switch (choice)
    {
        case 0:
            menuLoop = false;
            break;
        case 1:
            Addition(numOne, numTwo);
            break;
        case 2:
            Subtraction(numOne, numTwo);
            break;
        case 3:
            Division(numOne, numTwo);
            break;
        case 4:
            Multiplication(numOne, numTwo);
            break;
        case 5:
            Remainder(numOne, numTwo);
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }

    return menuLoop;
}



bool menu = true;

do
{
    menu = Menu();
    
} while (menu);