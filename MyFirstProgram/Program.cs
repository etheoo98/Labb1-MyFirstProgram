/*
 * Author: Theodor Hägg (.NET23)
 * GitHub: https://github.com/etheoo98/MyFirstProgram
 * Date: September 12, 2023
 */

namespace MyFirstProgram;

internal static class Program
{
    public static void Main()
    {
        const int myNumber = 11; // Declared as constant since its value never changes.
        
        Console.WriteLine(myNumber > 10 // An Ternary Operator is used as an alternative to If-Else.
            ? "Talet är stort!"
            : "Oj. Lågt tal!"); // Unreachable code!

        Console.WriteLine("Vad heter du?"); // Prompt user.
        var name = Console.ReadLine(); // Store user input.

        Console.WriteLine($"Hej {name}!");

        for (var i = 0; i <= myNumber; i++) // For-Loop that iterates until the condition in the 2nd statement is true.
            Console.WriteLine(i);
    }
}