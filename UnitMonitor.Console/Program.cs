// Power Unit Monitor
// One unit's readings, printed as a status line.

const string AppName = "Power Unit Monitor";

string unitName = "GEN-101";

string site = "North Yard";

double temperature = 187.5;

int pressure = 96;

bool isRunning = true;

Console.WriteLine($"=== {AppName} ===\n{unitName} @ {site}\nTemp: {temperature:F1} °F | Pressure: {pressure} psi | Running: {isRunning}" );

Console.Write("Enter new temperature: ");

string input = Console.ReadLine() ?? "";
double newTemp = double.Parse(input);

double change = newTemp - temperature;

temperature = newTemp;

Console.WriteLine($"{unitName} temperature changed by {change:+0.0;-0.0} °F (now {temperature:F1} °F)");
