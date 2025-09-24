int x, y;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
string tekst = "";


if (x == 0 && y == 0)
{
    tekst = "Punt ligt in de oorsprong.";
}
else if (x >= 0)
{
    if (y >= 0)
    {
        tekst = "Punt ligt in het eerste kwadrant.";
    }
    else
    {
        tekst = "Punt ligt in het vierde kwadrant.";
    }
}
else if (x < 0)
{
    if (y > 0)
    {
        tekst = "Punt ligt in het tweede kwadrant.";
    }
    else
    {
        tekst = "Punt ligt in het derde kwadrant.";
    }
}

Console.WriteLine(tekst);
