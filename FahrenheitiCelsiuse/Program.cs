Console.WriteLine("Enter temperature system degrees (c/f):");
char userOperator = Char.Parse(Console.ReadLine());

switch (userOperator)
{
    case 'c':
        Console.WriteLine("Enter degrees Celsius:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = ConvertToFahrenheit(celsius);
        Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        break;
    case 'f':
        Console.WriteLine("Enter degrees Fahrenheit:");
        double fahr = double.Parse(Console.ReadLine());
        double cels = ConvertToCelsius(fahr);
        Console.WriteLine($"{fahr}°F = {cels}°C");
        break;
    default:
        Console.WriteLine("Vale valik!");
        break;
}

static double ConvertToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5 / 9;
}

static double ConvertToFahrenheit(double celsius)
{
    return (celsius * 9 / 5) + 32;
}