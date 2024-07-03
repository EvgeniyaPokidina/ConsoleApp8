//Напишите программу, где:
//На ввод берется число от пользователя и передается в функцию.
//Функция должна выводить все нечетные числа от 1 до этого числа не
//включительно и делать это рекурсивно


Console.Write("Введите n:");
int n;
int.TryParse(Console.ReadLine(), out n);

void NumberOut(int n)
{
    {
        if (n == -1) return ;
        else NumberOut(n - 2);
         Console.Write(n + " ");
        
    }


}
NumberOut(n);
