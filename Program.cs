﻿using Day8_Practice;
Console.WriteLine("1)Enter String \n2)LowerCase Alphabet \n3)Html Tags \n4)Number Of Occurences \n5)Image File Extension \n6)Website Address");
int option = int.Parse(Console.ReadLine());
while (true)
{
    switch (option)
    {
        case 1:
            Strin str1 = new Strin();
            str1.checkstring();
            break;
        case 2:
            LowerCase lower = new LowerCase();
            lower.CheckLowerCase();
            break;
        case 3:
            HtmlTags html = new HtmlTags();
            html.CheckHtmlTags();
            break;
        case 4:
            NumberofOccurences numberof = new NumberofOccurences();
            numberof.CheckNumberofOccurences();
            break;
        case 5:
            ImageFileExtension image = new ImageFileExtension();
            image.CheckImageFileExtension();
            break;
        case 6:
            WebsiteAddress website = new WebsiteAddress();
            website.CheckWebsiteAddress();
            break;

    }
}

