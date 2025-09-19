int getal1, getal2, totaal;

Console.Write("Geef 1 getal in : ");
getal1 = int.Parse(Console.ReadLine());
Console.Write("Geef 1 getal in : ");
getal2 = int.Parse(Console.ReadLine());

if (getal1 >= getal2)
{
    totaal = getal1 - getal2;

    Console.WriteLine($"{getal1} - {getal2} = {totaal}. ");
}
else
{
    totaal = getal2 - getal1;

    Console.WriteLine($"{getal2} - {getal1} = {totaal}. ");
}

Console.WriteLine("Druk op Enter om af the sluiten");
Console.ReadLine();