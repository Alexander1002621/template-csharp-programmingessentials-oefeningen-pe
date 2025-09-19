double celcius, fahrenheit;


Console.Write("geef graden celcius aan:");
celcius = double.Parse(Console.ReadLine());


fahrenheit = celcius * 9 / 5 + 32;

Console.WriteLine($"Fahrenheit: {fahrenheit}");
Console.WriteLine();