

string path = @"C:\Users\elisilu\Documents\C#\MyFolder\File1.txt";

Console.WriteLine("Directory Separator Char: " + Path.DirectorySeparatorChar);
Console.WriteLine("Path Separator: " + Path.PathSeparator);
Console.WriteLine("Get Diretory Name: " + Path.GetDirectoryName(path));
Console.WriteLine("Get File Name: " + Path.GetFileName(path));
Console.WriteLine("Get File Name (without extension): " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("Get Extension: " + Path.GetExtension(path));
Console.WriteLine("Get Full Path: " + Path.GetFullPath(path));
Console.WriteLine("Get Temp Path: " + Path.GetTempPath());