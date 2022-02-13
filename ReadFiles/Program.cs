using static System.Console;

string filePath = @"C:\dev\texto.txt";

using var file = new StreamReader(filePath);
string? line;

while ((line = file.ReadLine()) != null)
  Console.WriteLine(line);

file.Close();
ReadLine();

static void ReadFile(string filePath)
{
  filePath = Path.Combine(filePath, "texto.txt");
  var data = File.ReadAllText(filePath);
  WriteLine(data);
  ReadLine();
}

static void ReadLineLine(string filePath)
{
  // Lê um arquivo linha a linha
  var lines = File.ReadAllLines(filePath);
  foreach (var line in lines)
    WriteLine(line);
  ReadLine();
}