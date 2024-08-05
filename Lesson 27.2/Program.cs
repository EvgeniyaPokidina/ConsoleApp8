// Создайте класс "Банковский счет", содержащий методы для выполнения операций со счетом, такие как пополнение, снятие денег, проверка
// баланса и т.д. Напишите код, который использует эти методы для управления банковским счетом.
// Текущий баланс клиента задать как переменную. Манипулировать балансом, вызывая методы.

using Lesson_27._2;

decimal clientBalance = 0;
BankAccount bankAccount = new BankAccount();
bool program=true;
do
{
    Console.Clear();
    Console.WriteLine("Какое действие вы хотите выполнить:\n"+
        "1 - пополнить\n"+
        "2 - снять\n"+
        "3 - проверить баланс");
    string str=Console.ReadLine()!;
    switch (str)
    {
        case "пополнить":
            {
                decimal addSum;
                Console.Write("Какую сумму вы хотите внести: ");
                if (decimal.TryParse(Console.ReadLine(), out addSum)&& addSum>0)
                    clientBalance=bankAccount.AddMoney(clientBalance, addSum);
                else Console.WriteLine("Неверная сумма");
            }
            break;
        case "снять":
            {
                decimal subSum;
                Console.Write("Какую сумму вы хотите снять: ");
                if (decimal.TryParse(Console.ReadLine(), out subSum) && subSum > 0)
                    clientBalance = bankAccount.WithdrawMoney(clientBalance, subSum);
                else Console.WriteLine("Неверная сумма");
            }
            break;
        case "проверить баланс":bankAccount.PrintBalance(clientBalance); break;
        default: Console.WriteLine("Неверная команда"); break;
    }
    Console.ReadKey();
}
while (program==true);

  





