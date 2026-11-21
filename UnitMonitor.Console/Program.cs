// Power Unit Monitor
// One unit's readings, printed as a status line.

//General Unit Info
const string AppName = "Power Unit Monitor";
string unitName = "GEN-101";
string site = "North Yard";

//Health (Engine Readings)
double coolantTemp = 187.5;
int oilPressure = 96;

//Power Info
double powerKw = 1450;
int ratedKw = 2000;
bool isRunning = powerKw >= 100;

//CB Status
bool cbClosed = true;
string cbText = cbClosed ? "CB Closed" : "CB Open";

//Connection Status
int minutesSinceLastReading = 1;
string connection = minutesSinceLastReading switch
{
    >= 3 => "Disconnected",
    >= 2 => "Unstable",
    _ => "Connected"
};

//Coolant Temp Status
string tempStatus = coolantTemp switch
{
    > 220 => "Critical",
    > 200 => "Warning",
    _ => "OK"
};

string health = !isRunning ? "Offline" : tempStatus;

//Unit Output
Console.WriteLine($"=== {AppName} ===");

Console.WriteLine($"{unitName} @ {site}");
Console.WriteLine($"Power: {powerKw} kW of {ratedKw} kW | Running: {isRunning}");
Console.WriteLine($"Coolant: {coolantTemp:F1} °F | Oil pressure: {oilPressure} psi");
Console.WriteLine($"Health: {health} | Connection: {connection} | {cbText}");

//New Coolant Temp
Console.Write("Enter new coolant temperature: ");

string input = Console.ReadLine() ?? "";
double newTemp = double.Parse(input);
double change = newTemp - coolantTemp;

coolantTemp = newTemp;
tempStatus = coolantTemp switch
{
    > 220 => "Critical",
    > 200 => "Warning",
    _ => "OK"
};
health = !isRunning ? "Offline" : tempStatus;

Console.WriteLine($"{unitName} coolant temperature changed by {change:+0.0;-0.0} °F (now {coolantTemp:F1} °F)");
Console.WriteLine($"Health is now: {health}");
