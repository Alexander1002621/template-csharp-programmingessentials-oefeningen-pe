int aantalVolwassenen, aantalKinderen;
double eindBedrag;

Console.WriteLine("voer het aantal volwassene in:");
aantalVolwassenen = int.Parse(Console.ReadLine());
Console.WriteLine("voer het aantal kinderen onder 12 jaar in:");
aantalKinderen = int.Parse(Console.ReadLine());

eindBedrag = (aantalVolwassenen * 10) + (aantalKinderen * 7.5);

eindBedrag = Math.Round(eindBedrag, 0);

Console.WriteLine($"Totaal te betalen:{eindBedrag} euro");
Console.ReadLine();
