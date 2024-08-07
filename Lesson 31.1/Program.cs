// Учет сотрудников в компании.Разработайте программу для учета сотрудников в компании. Каждыйсотрудник должен иметь имя, фамилию и должность.
// Реализуйте следующие функции:
//Добавление нового сотрудника в список.//Удаление сотрудника по его фамилии.//Поиск сотрудника по его имени или должности.
//Вывод списка всех сотрудников.Подсчет количества сотрудников в компании.
List<Employee> employees = new List<Employee>();
do
{
    Console.Clear();
    Console.WriteLine("1 - Добавить нового сотрудника\n" +
        "2 - Удалить сотрудника по фамилии\n" +
        "3 - Поиск сотрудника по его имени или должности\n"+
        "4 - Показать количество сотрудников");
    foreach (var employee in employees)
    {
        Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.positionName);
    }
    Console.WriteLine();
    Console.Write("Выберите пункт меню: ");
    int n;
    int.TryParse(Console.ReadLine(), out n);
    switch (n)
    {
        case 1:
            {
                Console.Write("Введите имя сотрудника: ");
                string firstname = Console.ReadLine()!;
                Console.Write("Введите фамилию сотрудника: ");
                string lastName = Console.ReadLine()!;
                Console.Write("Введите должность сотрудника: ");
                string position = Console.ReadLine()!;
                Employee employee = new Employee(firstname, lastName, position);
                employees.Add(employee);
            }
            break;
        case 2:
            {
                Console.Write("Введите фамилию сотрудника: ");
                string name = Console.ReadLine()!;
                Employee employee = employees.Find(x => x.lastName == name);
                employees.Remove(employee);
            }
            break;
        case 3:
            {
                Console.WriteLine("1 - поиск сотрудника по имени\n" +
                    "2 - поиск сотрудника по должности");
                Console.Write("Введите номер: ");
                int m;
                int.TryParse(Console.ReadLine(), out m);
                switch (m)
                {
                    case 1:
                        {
                            Console.Write("Введите имя сотрудника: ");
                            string name = Console.ReadLine()!;
                            Employee employee = employees.Find(x => x.firstName == name);
                            Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.positionName);
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введите должнось сотрудника: ");
                            string position = Console.ReadLine()!;
                            Employee employee = employees.Find(x => x.positionName == position);
                            Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.positionName);
                            Console.ReadKey();
                        }
                        break;
                }
            }
            break;
        case 4:
            {
                Console.WriteLine("Количество сотрудников: "+ employees.Count);
                Console.ReadKey();
            }
            break;
           
    }
}
while (true);
struct Employee
{
    public string firstName;
    public string lastName;
    public string positionName;
    public Employee(string name, string fio, string position)
    {
        firstName = name;
        lastName = fio;
        positionName= position;
    }
}

    




