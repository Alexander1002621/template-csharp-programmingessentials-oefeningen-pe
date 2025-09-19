int getal1, getal2, uitkomst;
string resultaat = "";

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());

if (getal2 == 0)
{
    resultaat += $"{getal1} is niet deelbaar door 0";
}

else
{
    uitkomst = getal1 / getal2;
    resultaat += $"{getal1} / {getal2} = {uitkomst}";
}

Console.WriteLine(resultaat);
Console.ReadLine();