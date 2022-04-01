//Try to find a txt file and open it. If the file not exists, catch an exception an ends the FileStream resource.


FileStream fs = null;
try
{
    fs = new FileStream(@"C:\Users\elisilu\Documents\C#\TestFile.txt", FileMode.Open);
    StreamReader sr = new StreamReader(fs);
    string line = sr.ReadLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(line);
    Console.ResetColor();
}
catch (FileNotFoundException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e.Message);
    Console.ResetColor();
}
finally
{
    if (fs != null)
    {
        fs.Close();
    }
}