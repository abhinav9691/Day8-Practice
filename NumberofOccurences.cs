using System.Text.RegularExpressions;

internal class NumberofOccurences
{
    public void CheckNumberofOccurences()
    {
        Console.WriteLine("Enter string to find Number Of Occurences:");
        string s3 = Console.ReadLine();
        string pattern4 = "fox(es)?";
        int count = Regex.Matches(s3, pattern4).Count;
        Console.WriteLine("There are " + count + " Occurences");
    }
}