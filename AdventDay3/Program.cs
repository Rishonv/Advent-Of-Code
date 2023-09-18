using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

string? line = "";
StreamReader sr = new StreamReader("./Input.txt");
int sum = 0;

line = sr.ReadLine();
while (line != null)
{
    string line2 = sr.ReadLine()!;
    string line3 = sr.ReadLine()!;

    for (int i = 0; i < line.Length; i++)
    {
        if (line2.Contains(line[i]) && line3.Contains(line[i]))
        {
            int value = (int)line[i];
            int priority = value >= 97 ? value - 96 : value - 38;
            sum += priority;
            Console.WriteLine(line[i]);
            break;
        }
    }
    line = sr.ReadLine();
}
Console.WriteLine(sum);