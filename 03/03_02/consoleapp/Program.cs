int jaartal;
bool schrikkeljaar = false;


Console.Write("geef een jaar in:");
jaartal = int.Parse(Console.ReadLine());


if (jaartal >= 1582)
{
    if (jaartal % 4 == 0)
    {
        schrikkeljaar = true;
    }


    if (jaartal % 100 == 0)
    {
        schrikkeljaar = false;
    }


    if (jaartal % 400 == 0)
    {
        schrikkeljaar = true;
    }


    if (jaartal % 4000 == 0)
    {
        schrikkeljaar = false;
    }
}

else
{
    if (jaartal % 4 == 0)
    {
        schrikkeljaar = true;
    }
}

if (schrikkeljaar == true)
{
    Console.WriteLine($"{jaartal} is een schrikkeljaar");
}
else
{
    Console.WriteLine($"{jaartal} is geen schrikkeljaar");
}