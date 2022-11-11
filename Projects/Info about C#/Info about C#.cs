using System;
//**********STRINGS***************
string name = "Harun Yahya";
Console.WriteLine(name.Length); // length of string
Console.WriteLine(name.ToUpper()); // to Upper Case
Console.WriteLine(name.ToLower()); // to Lower Case
Console.WriteLine(name.Contains("Yahya")); // does string contain another str or char
Console.WriteLine(name[1]); // to write second index
Console.WriteLine(name.IndexOf("a")); // index of "a"
Console.WriteLine(name.Substring(6)); // to write from 6th index to the end
Console.WriteLine(name.Substring(6,3)); // to write from 6th index to 8th (3 pcs.)

//**********NUMBERS***************
int nbr1, nbr2, result;

nbr1 = 10;
nbr2 = 5;
Console.Write(nbr1++ );
Console.Write(", " + nbr1--);

result = nbr1 + nbr2;
Console.Write(", " + result);

result = nbr1 - nbr2;
Console.Write(", " + result);

result = nbr1 * nbr2;
Console.Write(", " + result);

result = nbr1 / nbr2;
Console.Write(", " + result);

result = nbr1 % nbr2;
Console.Write(", " + result);