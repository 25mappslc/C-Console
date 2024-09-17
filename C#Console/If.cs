class If 
{
    public static void Numbers(int number)
    {
        if(number > 0)
        {
            Console.WriteLine("Your number is positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine("Your number is negative.");
        }
        else
        {
            Console.WriteLine("Your number is zero.");
        }
    }

    public static void Health(int number)
    {
         if(number > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if(number > 50 )
        {
            Console.WriteLine("The player is in good condition.");
        }
        else if (number > 0)
        {
            Console.WriteLine("The player is in danger!");
        }
        else
        {
            Console.WriteLine("Game Over.");
        }
    }
}