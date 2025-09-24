int getal1, getal2, getal3, cijferCode, uitkomst;
string letterCode, resultaat;

getal1 = int.Parse(Console.ReadLine());
getal2 = int.Parse(Console.ReadLine());
getal3 = int.Parse(Console.ReadLine());
letterCode = Console.ReadLine();
cijferCode = int.Parse(Console.ReadLine());

if (letterCode.ToUpper() == "A")
{
    if (cijferCode == 1)
    {
        uitkomst = getal1 + getal2;
        resultaat = $"{getal1} + {getal2} = {uitkomst}";
    }
    else if (cijferCode == 2)
    {
        uitkomst = getal2 + getal3;
        resultaat = $"{getal2} + {getal3} = {uitkomst}";
    }
    else
    {
        uitkomst = getal1 + getal3;
        resultaat = $"{getal1} + {getal3} = {uitkomst}";
    }
}

else
{
    if (cijferCode == 1)
    {
        uitkomst = getal1 - getal2;
        resultaat = $"{getal1} - {getal2} = {uitkomst}";
    }
    else if (cijferCode == 2)
    {
        uitkomst = getal2 - getal3;
        resultaat = $"{getal2} - {getal3} = {uitkomst}";
    }
    else
    {
        uitkomst = getal1 - getal3;
        resultaat = $"{getal1} - {getal3} = {uitkomst}";
    }
}

Console.WriteLine(resultaat);
Console.ReadLine();