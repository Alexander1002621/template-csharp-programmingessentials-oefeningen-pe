string voornaam, familienaam;
int leeftijd;

voornaam = Console.ReadLine();
familienaam = Console.ReadLine();
leeftijd = int.Parse(Console.ReadLine());

if (leeftijd >= 18)
{
    Console.WriteLine($"{voornaam} {familienaam}: Volwassenen");
}

if (leeftijd < 18)
{
    Console.WriteLine($"{voornaam} {familienaam}: Jeugd");

}


Console.WriteLine("druk op enter om af te sluiten");
Console.WriteLine();