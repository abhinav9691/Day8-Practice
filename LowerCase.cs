using System.Text.RegularExpressions;

internal class LowerCase
{
    public void CheckLowerCase()
    {
        Console.WriteLine("Enter LowerCase : ");
        string s1 = Console.ReadLine();
        string pattern2 = "^[a-z]{4,}[_]{1}$";
        Regex regex1 = new Regex(pattern2);
        if (regex1.IsMatch(s1))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valid LowerCase");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid LowerCase");
            Console.ResetColor();
        }
    }
}