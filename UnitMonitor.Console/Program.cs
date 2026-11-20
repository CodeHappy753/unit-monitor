// Power Unit Monitor
// One unit's readings, printed as a status line.

const string AppName = "Power Unit Monitor";

string unitName = "GEN-101";

string site = "North Yard";

double coolantTemp = 225;

int oilPressure = 96;

double powerKw = 1450;

int ratedKw = 2000;

bool isRunning = powerKw >= 100;

string tempStatus = coolantTemp switch
{
    > 220 => "Critical",
    > 200 => "Warning",
    _ => "OK"
};

string health = !isRunning ? "Offline" : tempStatus;

Console.WriteLine($"=== {AppName} ===\n{unitName} @ {site}\nCoolant: {coolantTemp:F1} °F | Oil pressure: {oilPressure} psi | Running: {isRunning}" );
Console.WriteLine($"Health: {health}");
Console.Write("Enter new temperature: ");

string input = Console.ReadLine() ?? "";
double newTemp = double.Parse(input);

double change = newTemp - coolantTemp;

coolantTemp = newTemp;

Console.WriteLine($"{unitName} temperature changed by {change:+0.0;-0.0} °F (now {coolantTemp:F1} °F)");
