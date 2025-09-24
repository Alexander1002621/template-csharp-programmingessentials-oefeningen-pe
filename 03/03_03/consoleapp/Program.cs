int getal1, getal2, getal3, grootsteGetal;
double totaal;
string letter;

getal1 = int.Parse(Console.ReadLine());

getal2 = int.Parse(Console.ReadLine());

getal3 = int.Parse(Console.ReadLine());

letter = Console.ReadLine();


switch (letter)
{
    case "A":
        totaal = getal1 + getal2 + getal3;
        Console.WriteLine($"Uitkomst:  {totaal}");
        break;

    case "B":
        totaal = getal1 * getal3;
        Console.WriteLine($"Uitkomst: {totaal}");
        break;

    case "C":
        totaal = getal3 - getal2;
        Console.WriteLine($"Uitkomst:  {totaal}");
        break;

    case "D":
        if (getal1 >= 0)
        {
            totaal = Math.Sqrt(getal1);
            Console.WriteLine($"Uitkomst:  {totaal}");
        }
        else
        {
            Console.WriteLine("Foutieve invoer.");
        }
        break;

    default:
        if (getal1 > getal2)
        {
            grootsteGetal = getal1;
        }
        else
        {
            grootsteGetal = getal2;
        }

        if (grootsteGetal < getal3)
        {
            grootsteGetal = getal3;
        }
        Console.WriteLine($"Uitkomst: {grootsteGetal}");
        break;
}
