//Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского 
//счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей 
//значение и вывести это значение на печать.
using System;

namespace EnumExzample
{
    enum BankAcc
    {
        Current, // Текущий счёт
        Savings  // Сберегательный счёт
    }

    class Program
    {
        static void Main()
        {   
            Console.WriteLine("упражнение 3.1");
            // Создаем переменную типа перечисления и присваиваем ей значение
            BankAcc myAccount = BankAcc.Savings;

            // Выводим значение на экран
            Console.WriteLine($"Тип счета: {myAccount}");
        }
    }
}