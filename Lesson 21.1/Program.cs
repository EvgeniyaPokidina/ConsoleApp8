//Создайте вручную папку с домашним заданием.
//Напишите программу, которая просит пользователя ввести путь к файлу и текст, который необходимо записать в него.
//После записи вывести на экран информацию “Файл успешно записан”.
//Создать еще 2 файла с названиями “Файл2” и “Файл3” программно
//Вывести на экран содержимое 1го файла.

Console.Write("Введите путь к файлу:");
string path = Console.ReadLine();
Console.Write("Введите текст для записи в файл:");
string text = Console.ReadLine();
try
{
    File.WriteAllText(path, text);
    Console.WriteLine("Файл успешно записан");

}
catch
{
    Console.WriteLine("Вы неверно ввели путь к файлу");
}
Console.WriteLine(text);



string path1 = "C:/Users/User0/Desktop/Женя учеба/ДЗ/file2.txt";
File.Create(path1);
string path2 = "C:/Users/User0/Desktop/Женя учеба/ДЗ/file3.txt";
File.Create(path2);
