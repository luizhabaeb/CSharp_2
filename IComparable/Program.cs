using Interf_Compare.Entities;

string path = @"C:\Users\elisilu\Documents\C#\func.txt";

try
{
    using (StreamReader sr = File.OpenText(path)) //Abrir e ler o arquivo
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort(); //list.Sort(); Ordenar uma lista
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }


    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred: ");
    Console.WriteLine(e.Message);
}

