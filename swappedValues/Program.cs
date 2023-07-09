using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Swapping numbers");

        Console.Write("Enter the first number -   ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number -  ");
        int num2 = int.Parse(Console.ReadLine());   

        int swapper = num1;
        num1 = num2;
        num2 = swapper;

        Console.WriteLine("After swapping ");
        Console.WriteLine("The first number is " + num1);
        Console.WriteLine("The second number is " + num2);


    }
}

