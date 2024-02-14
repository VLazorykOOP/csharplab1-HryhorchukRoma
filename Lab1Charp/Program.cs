using System;
class Program
{
    static void Main()
    {
        task1();
        //task2();
        //task3();
        //task4();
        //task5();
        //task6();
    }
    static void task1()
    {

        Console.WriteLine("Enter a1:");
        string a1 = Console.ReadLine();

        Console.WriteLine("Enter b1:");
        string b1 = Console.ReadLine();

        Console.WriteLine("Enter a2:");
        string a2 = Console.ReadLine();

        Console.WriteLine("Enter b2:");
        string b2 = Console.ReadLine();

        double rezult = Math.Sqrt(Math.Pow(int.Parse(a1) - int.Parse(a2), 2) + Math.Pow(int.Parse(b1) - int.Parse(b2), 2));
        Console.WriteLine("Distance from A(" + a1 + "," + b1 + ") to B(" + a2 + "," + b2 + ") is: " + rezult.ToString("F6"));
    }
    static void task2()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a % 2 == 0) ? "Even" : "Odd");
    }
    static void task3()
    {
        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        int y = int.Parse(Console.ReadLine());
        if (((Math.Pow(x, 2) + Math.Pow(y, 2)) < 100 && (Math.Pow(x,
        2) + Math.Pow(y, 2)) > 25) && y > 0)
        {
            Console.WriteLine("In Range");
        }
        else if (((Math.Pow(x, 2) + Math.Pow(y, 2)) == 100 && (Math.Pow(x,
          2) + Math.Pow(y, 2)) == 25) && y == 0)
        {
            Console.WriteLine("On  Line");
        }
        else
        {
            Console.WriteLine("Out of Range");
        }
    }
    static void task4()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        string[] arr = new string[4] { "піка", "хреста", "чірва", "бубна" };
        Console.WriteLine(arr[a - 1]);
    }
    static int multiply(int a, int b)
    {
        return a * b;
    }
    static void task5()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Result of Multiplying is " + multiply(a, b));
    }
    static void task6()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m:");
        int m = int.Parse(Console.ReadLine());
        double rez = (((double)(n + 1) / ((n * n + m * m + 1))) - ((double)(1) / ((m + 1) * (n + 1))));
        Console.WriteLine("Result is " + rez.ToString("F6"));
    }
}
