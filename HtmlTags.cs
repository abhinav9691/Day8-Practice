using System.Text.RegularExpressions;

internal class HtmlTags
{
    public void CheckHtmlTags()
    {
        Console.WriteLine("Enter Html Tags : ");
        string s2 = Console.ReadLine();
        string pattern3 = "<([a-z]+)(?![^>]*/>)[^>]*";
        Regex regex2 = new Regex(pattern3);
        if (regex2.IsMatch(s2))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valid Html Tags");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Html Tags");
            Console.ResetColor();
        }
    }
}