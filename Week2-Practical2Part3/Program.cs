
Main();

static void Main()
{

    int menuChoice;

    Console.WriteLine("\nCircle Area Calculator");

    double radius;
    bool exitPressed = false;

    while (!exitPressed)
    {

        menuChoice = MainMenu();

        switch (menuChoice)
        {
            case 0:
                Console.WriteLine($"\nYou have entered: {menuChoice}");
                Console.WriteLine("Exiting... Goodbye");
                exitPressed = true;
                break;
            case 1:
                Console.WriteLine($"\nYou have entered: {menuChoice}");
                Console.WriteLine("Please enter the radius of your cirlce:");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nThe area of your cirlce is: {CircleArea(radius)}");
                break;

        }

    }

    

}

static int MainMenu()
{

    int result = -1;

    Console.WriteLine("\nPlease select one of the following options:");
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - Calculate area of cirlce");

    while(result != 0 &&  result != 1)
    {

        try
        {

            result = Convert.ToInt32(Console.ReadLine());

            if (result < 0 || result > 1)
            {

                Console.WriteLine("\nInvalid input - please enter 0 or 1:");

            }


        } catch (Exception ex)
        {

            Console.WriteLine("\nInvalid input - please try again:");

        }

        

    }

    return result;
    

}

static double CircleArea(double radius)
{

    return Math.PI * Math.Pow(radius, 2);

}