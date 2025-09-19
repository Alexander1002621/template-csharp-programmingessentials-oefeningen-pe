int landingsplaats, punten;


landingsplaats = int.Parse(Console.ReadLine());

if (landingsplaats == 1)
{
    punten = 0;
}
else if (landingsplaats == 2)
{
    punten = 20;
}
else if (landingsplaats == 3)
{
    punten = 50;
}
else
{
    punten = 100;
}
Console.WriteLine($"{punten} punten.");