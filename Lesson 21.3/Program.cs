string path = Environment.CurrentDirectory;
Console.WriteLine(path);
Console.Write("Введите название папки для перехода:");
string destination = Console.ReadLine()!;
path += $"{destination}";
if (Directory.Exists(destination))
{
    DirectoryInfo dir = new DirectoryInfo(destination);
    Console.WriteLine(dir.FullName);
}
else
{
    Console.WriteLine("Такой папки не существует");
}



