//FILE - FILEINFO

string sourcePath = @"C:\Users\elisilu\Documents\C#\File1.txt";
string targetPath = @"C:\Users\elisilu\Documents\C#\File2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);  //variável vetor [] de string 
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred.");
    Console.WriteLine(e.Message);
}