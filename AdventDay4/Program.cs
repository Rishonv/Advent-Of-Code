using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Diagnostics.CodeAnalysis;

string? line = "";
StreamReader sr = new StreamReader("./Input.txt");
int total = 0;

line = sr.ReadLine();
while (line != null)
{
    int[] firstHArr = { 0, 0 };
    int[] secondHArr = { 0, 0 };
    string firstHalf = line.Substring(0, line.IndexOf(","));
    string secondHalf = line.Substring(line.IndexOf(",") + 1);

    firstHArr[0] = Int32.Parse(firstHalf.Substring(0, firstHalf.IndexOf("-")));
    firstHArr[1] = Int32.Parse(firstHalf.Substring(firstHalf.IndexOf("-") + 1));
    secondHArr[0] = Int32.Parse(secondHalf.Substring(0, secondHalf.IndexOf("-")));
    secondHArr[1] = Int32.Parse(secondHalf.Substring(secondHalf.IndexOf("-") + 1));

    // // Checks if first string starts before and ends after (contains the second string)
    // if ((firstHArr[0] <= secondHArr[0]) && (firstHArr[1] >= secondHArr[1]))
    // {
    //     Console.WriteLine($"this is first {firstHArr[0]} {firstHArr[1]}");
    //     total++;
    // }
    // // checks if second string contains first
    // else if ((secondHArr[0] <= firstHArr[0]) && (secondHArr[1] >= firstHArr[1]))
    // {
    //     Console.WriteLine($"This is second {secondHArr[0]} {secondHArr[1]}");
    //     total++;
    // }

    //second part solution
    if (!(firstHArr[0] > secondHArr[1] || secondHArr[0] > firstHArr[1]))
    {
        total++;
    }
    line = sr.ReadLine();
}
Console.WriteLine(total);