using System;

namespace EnumExzample
{
    enum AccountType
    {
        Current, // Текущий счёт
        Savings  // Сберегательный счёт
    }

    class Program
    {
        static void Main()
        {
            // Создаем переменную типа перечисления и присваиваем ей значение
            AccountType myAccount = AccountType.Savings;

            // Выводим значение на экран
            Console.WriteLine($"Тип счета: {myAccount}");
        }
    }
}