// Simple Password Generator,Generate random passwords.

using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Password Generator");
        Console.Write("Enter password length: ");
        int length = int.Parse(Console.ReadLine());

        string password = GeneratePassword(length);
        Console.WriteLine($"Generated Password: {password}");
    }
    static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+<>?";
        StringBuilder res = new StringBuilder();
        Random rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            res.Append(validChars[rnd.Next(validChars.Length)]);
        }

        return res.ToString();
    }
}