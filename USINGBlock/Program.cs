

string path = @"C:\Users\elisilu\Documents\C#\File1.txt";

try
{ 
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("ERROR: ");
    Console.WriteLine(e.Message);
}
