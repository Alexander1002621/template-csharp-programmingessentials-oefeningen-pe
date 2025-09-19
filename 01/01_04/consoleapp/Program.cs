double TotaalteBetalen, totaalBedrag, prijs, btwBedrag;
int nationaleOp, internationaleOp, alleOproepen;

internationaleOp = int.Parse(Console.ReadLine());
nationaleOp = int.Parse(Console.ReadLine());


alleOproepen = nationaleOp + internationaleOp;
prijs = alleOproepen * 0.12;
totaalBedrag = prijs + 23;
btwBedrag = totaalBedrag * 21 / 100;
TotaalteBetalen = totaalBedrag + btwBedrag;

Console.WriteLine($" totaal te betalen: {TotaalteBetalen:N2}  euro");