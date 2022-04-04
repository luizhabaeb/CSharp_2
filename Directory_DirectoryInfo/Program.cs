

string path = @"C:\Users\elisilu\Documents\C#\MyFolder";


try //1º test - List all subfolders from 'MyFolder'
{
    var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //*.* "qualquer nome de arquivo"."qualquer extensão"
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("FOLDERS: ");
    Console.ResetColor();
    foreach (string s in folders)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(s);   
        Console.ResetColor();
    }
    Console.WriteLine();
    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //*.* "qualquer nome de arquivo"."qualquer extensão"
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("FILES: ");
    Console.ResetColor();
    foreach (string f in files)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(f);
        Console.ResetColor();
    }

    Directory.CreateDirectory(path + "\\NewFolder");  //Creat a new Folder - Another way: @"\NewFolder"
}

catch (IOException e)
{
    Console.WriteLine("ERROR: ");
    Console.WriteLine(e.Message);
}


