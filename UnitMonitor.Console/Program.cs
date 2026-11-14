// Power Unit Monitor
// One unit's readings, printed as a status line.

const string AppName = "Power Unit Monitor";

string unitName = "GEN-101";

string site = "North Yard";

decimal temperature = 187.5m;

int pressure = 96;

bool isRunning = true;

Console.WriteLine($"=== Power Unit Monitor ===\n{unitName} @ {site}\nTemp: {temperature:F1} °F | Pressure: {pressure} psi | Running: {isRunning}" );
