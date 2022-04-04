

string sourcePath = @"C:\Users\elisilu\Documents\C#\File1.txt";
string targetPath = @"C:\Users\elisilu\Documents\C#\File2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("ERROR: ");
    Console.WriteLine(e.Message);
}
