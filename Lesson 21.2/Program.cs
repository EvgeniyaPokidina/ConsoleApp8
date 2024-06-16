//Напишите программу, которая просит пользователя ввести путь к файлу на компьютере. Затем программа должна проверить, существует ли указанный файл,
//и вывести соответствующее сообщение. Если файл существует, программа должна также вывести его размер в байтах, дату последнего изменения и расширение файла

using System.ComponentModel.Design;

Console.Write("ВВедите путь к файлу:");
string path = Console.ReadLine()!;
if (File.Exists(path)) 
{
    Console.WriteLine("Файл существует");
    FileInfo fileInfo = new FileInfo(path);
    Console.WriteLine("Размер файла в байтах:" +fileInfo.Length);
    Console.WriteLine("Дата последнего изменения:" + fileInfo.LastWriteTime);
    Console.WriteLine("Расширение файла:" + fileInfo.Extension);
}
 else
{ 
    Console.WriteLine("Файл не существует"); 
}