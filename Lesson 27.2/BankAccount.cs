﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27._2
{
    internal class BankAccount
    {
        public decimal AddMoney(decimal balance, decimal addSum)
        {
            Console.WriteLine($"Внесено {addSum}");
            return balance + addSum;
        }
        public decimal WithdrawMoney(decimal balance, decimal subSum)
        {
            Console.WriteLine($"Снято {subSum}");
            return balance - subSum;
        }
        public void PrintBalance(decimal balance)
        {
            Console.WriteLine("Ваш баланс: " + balance);
        }
    }
}
