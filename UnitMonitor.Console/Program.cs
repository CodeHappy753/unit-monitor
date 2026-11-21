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

bool cbClosed = true;

string cbText = cbClosed ? "CB Closed" : "CB Open";

int minutesSinceLastReading = 1;

string connection = minutesSinceLastReading switch
{
    >= 3 => "Disconnected",
    >= 2 => "Unstable",
    _ => "Connected"
};

string tempStatus = coolantTemp switch
{
    > 220 => "Critical",
    > 200 => "Warning",
    _ => "OK"
};

string health = !isRunning ? "Offline" : tempStatus;

Console.WriteLine($"=== {AppName} ===\n{unitName} @ {site}\nCoolant: {coolantTemp:F1} °F | Oil pressure: {oilPressure} psi | Running: {isRunning}" );
Console.WriteLine($"Health: {health}");
Console.WriteLine($"Connection: {connection}");
Console.Write("Enter new temperature: ");

string input = Console.ReadLine() ?? "";
double newTemp = double.Parse(input);

double change = newTemp - coolantTemp;

coolantTemp = newTemp;

Console.WriteLine($"{unitName} temperature changed by {change:+0.0;-0.0} °F (now {coolantTemp:F1} °F)");
