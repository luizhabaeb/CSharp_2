

string path = @"C:\Users\elisilu\Documents\C#\file1.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream) //Enquanto não chegar no final da Stream, vai ler a linha e mostrar na tela.. sr.ReadLine()
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred: ");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();

}