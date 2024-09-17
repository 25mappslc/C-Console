class Var
{
    public static void MyVar()
    {
        string myName = "Lee";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Lee";
        string lastName = "Mapps";
        string wholeName = firstName + " " + lastName;
        int age = 51;
        float gpa = 3.2f;
        double height = 6.2;
        decimal dollar = 100.95m;
        bool is_Mii = true;
        char grade = 'B';

        Console.WriteLine(wholeName);
        Console.WriteLine(grade);
        Console.WriteLine(is_Mii);
        Console.WriteLine(dollar);
        Console.WriteLine(height);
        Console.WriteLine(gpa);
        Console.WriteLine(age);
        
        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
    }
}