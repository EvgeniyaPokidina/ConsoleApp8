//Напишите программу, которая позволяет пользователю удалить файл или папку. Программа должна запрашивать путь к файл или папке, которую нужно удалить, и выполнить удаление.
//Перед удалением, программа должна запрашивать подтверждение пользователя.

Console.WriteLine("Вы хотите удалить папку или файл?\n"+"1 - файл\n"+ "2 - папка");
int n = int.Parse(Console.ReadLine()!);
switch (n)
{
    case 1:
        {
            Console.Write("Введите путь к файлу:");
            string path = Console.ReadLine()!;
            if (File.Exists(path))
            {
                Console.WriteLine("Вы уверены?\n"+ "1 - да\n" + "2 - нет");
                int answer = int.Parse(Console.ReadLine()!);
                if (answer == 1)
                {
                    File.Delete(path);
                    Console.WriteLine("Файл успешно удален");
                }
                else
                {
                    Console.WriteLine("Файл не удален");
                }
            }
        }
        break;
    case 2:
        {
            Console.Write("Введите путь к папке:");
            string path = Console.ReadLine()!;
            if (Directory.Exists(path))
            {
                {
                    Console.WriteLine("Вы уверены?\n" + "1 - да\n" + "2 - нет");
                    int answer = int.Parse(Console.ReadLine()!);
                    if (answer == 1)
                    {
                        Directory.Delete(path);
                        Console.WriteLine("Папка успешно удалена");
                    }
                    else
                    {
                        Console.WriteLine("Папка не удалена");
                    }
                }
            }
        }
        break;
}