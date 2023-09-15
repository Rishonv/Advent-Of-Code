using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;

string? line = "";
StreamReader sr = new StreamReader("./Input.txt");
int totalScore = 0;

line = sr.ReadLine();
while (line != null)
{
    Console.WriteLine(line);
    (char, char) plays = (line[0], line[2]);

    int score = plays switch
    {
        ('A', 'X') => 3,
        ('A', 'Y') => 1,
        ('A', 'Z') => 2,
        ('B', 'X') => 1,
        ('B', 'Y') => 2,
        ('B', 'Z') => 3,
        ('C', 'X') => 2,
        ('C', 'Y') => 3,
        ('C', 'Z') => 1,
        (_, _) => 0
    };

    int outcome = line[2] switch
    {
        'X' => 0,
        'Y' => 3,
        'Z' => 6,
        _ => 0
    };

    line = sr.ReadLine();
    totalScore += score + outcome;
}
Console.WriteLine(totalScore);