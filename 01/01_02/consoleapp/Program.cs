 double prijsExclusief, prijsInclusief, btw, btwBedrag;

prijsExclusief = double.Parse(Console.ReadLine());
btw = int.Parse(Console.ReadLine());

btwBedrag = prijsExclusief * (btw / 100);
prijsInclusief = prijsExclusief + btwBedrag;

Console.WriteLine("Prijs inclusief BTW: " + prijsInclusief.ToString());
Console.ReadLine();