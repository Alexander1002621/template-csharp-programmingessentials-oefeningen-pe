int getal;
string naam, voornaam, tijdschrift = "";


voornaam = Console.ReadLine();
naam = Console.ReadLine();
getal = int.Parse(Console.ReadLine());


naam = naam.ToUpper();
voornaam = voornaam.ToLower();

switch (getal)
{
    case 1:
        tijdschrift = "\"Anna\"";
        break;
    case 2:
        tijdschrift = "\"Knippie\"";
        break;
    case 3:
        tijdschrift = "\"VtWonen\"";
        break;
    case 4:
        tijdschrift = "\"Voetbal International\"";
        break;
    case 5:
        tijdschrift = "\"Wandelen & fietsen\"";
        break;
    case 6:
        tijdschrift = "\"Zoom NL\"";
        break;
    case 7:
        tijdschrift = "\"Runners\"";
        break;
    default:
        tijdschrift = "-";
        break;

}

Console.WriteLine($"{voornaam} {naam}, tijdschrift: {tijdschrift}");
Console.WriteLine("Druk op Enter om af the sluiten");
Console.ReadLine();