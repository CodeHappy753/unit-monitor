// Power Unit Monitor
// One unit's readings, printed as a status line.

const string AppName = "Power Unit Monitor";

string unitName = "GEN-101";

string site = "North Yard";

double coolantTemp = 187.5;

int oilPressure = 96;

double powerKw = 1450;

int ratedKw = 2000;

bool isRunning = powerKw >= 100;

string health;

if (!isRunning)
{
    health = "Offline";
}
else if (coolantTemp > 220)
{
    health = "Critical";
}
else if (coolantTemp > 200)
{
    health = "Warning";
}
else
{
    health = "OK";
}

Console.WriteLine($"=== {AppName} ===\n{unitName} @ {site}\nCoolant: {coolantTemp:F1} °F | Oil Pressure: {oilPressure} psi | Running: {isRunning}" );
Console.WriteLine($"Health: {health}");
Console.Write("Enter new temperature: ");

string input = Console.ReadLine() ?? "";
double newTemp = double.Parse(input);

double change = newTemp - coolantTemp;

coolantTemp = newTemp;

Console.WriteLine($"{unitName} temperature changed by {change:+0.0;-0.0} °F (now {coolantTemp:F1} °F)");
