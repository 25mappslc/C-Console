class Arrays
{
    public static void Array1(string[] args)
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;

        Console.WriteLine(numbers[1]);

        string[] names = {"John", "Jaden", "Lee"};
        
        Console.WriteLine(names[1]);

        int[] grades = new int[5];

        grades[0] = 70;
        grades[1] = 73;
        grades[2] = 80;
        grades[3] = 95;
        grades[4] = 100;

        Console.WriteLine("Grades ");
        for(int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine(grades[i]);
        }
    }
}