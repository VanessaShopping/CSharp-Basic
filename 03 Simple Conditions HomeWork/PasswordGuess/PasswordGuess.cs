using System;

class PasswordGuess
{
    static void Main()
    {
        string pass = "s3cr3t!P@ssw0rd";
        string enterPass = Console.ReadLine();
        if (enterPass == pass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}