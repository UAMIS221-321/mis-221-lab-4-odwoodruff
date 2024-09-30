//Main

string userInput = GetMenuChoice(); //this is used for the main functions of the menu
while (userInput != "4")
{
    RouteEm(userInput);
    userInput = GetMenuChoice();
}
SayByeBye();

//end main
static string GetMenuChoice()
{
    DisplayMenu();
    return Console.ReadLine();
}

static void DisplayMenu()
{
    System.Console.WriteLine("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
}

static void RouteEm(string userInput)
{
    switch (userInput)
    {
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepPizza();
            break;




        default:
            System.Console.WriteLine("Invalid Input");
            break;
    }
}
static void SayByeBye()
{
    System.Console.WriteLine("Exit!");
}

static void PlainPizza()
{
    // Random number generator
    Random rand = new Random();

    // Generate a random number of rows between 8 and 12
    int rows = rand.Next(8, 13); //https://www.geeksforgeeks.org/c-sharp-random-next-method/
    // Outer loop controls the rows
    for (int i = rows; i >= 1; i--)
    {
        
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*\t"); // Tab (\t) for spacing 
        }
        Console.WriteLine(); 
    }
}

static void CheesePizza()
{
       
        Random rand = new Random();
        
        // Generate a random number of rows between 8 and 12
        int rows = rand.Next(8, 13); 

        
        for (int i = 0; i < rows; i++)
        {
            // Inner loop prints the pattern for each row
            for (int j = 0; j < rows - i; j++)
            {
                // 1st row alwaus begins with *
                if (i == 0 || j == 0 || j == rows - i - 1)
                {
                    Console.Write("*\t"); // Outline with *
                }
                else
                {
                    Console.Write("#\t"); // Inside with #
                }
            }
            Console.WriteLine(); 
        }
    }

    static void PepPizza(){
         
        Random rand = new Random();
        
        
        int rows = rand.Next(8, 13); 
        
        //nested loops for inner and outer rows
        for (int i = 0; i < rows; i++)
        {
           
            for (int j = 0; j < rows - i; j++)
            {
                // Print * for the first row, the first and last positions in each row
                if (i == 0 || j == 0 || j == rows - i - 1)
                {
                    Console.Write("*\t"); // Outline with *
                }
                else
                {
                    // Randomly decide if we should place a pepperoni slice
                    if (rand.Next(0, 5) == 0) //https://www.geeksforgeeks.org/c-sharp-random-next-method/
                    {
                        Console.Write("[]\t"); // Pepperoni slice
                    }
                    else
                    {
                        Console.Write("#\t"); // Inside with cheese (#)
                    }
                }
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
    



