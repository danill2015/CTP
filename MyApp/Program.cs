using System;



class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello, World!");

        GreetUser("GitUser");

    }



    static void GreetUser(string name)

    {

        Console.WriteLine($"Hello, {name}!");

    }

}