//Упражнение 3.1 Создать перечислимый тип данных отображающий виды банковского 
//счета (текущий и сберегательный). Создать переменную типа перечисления, присвоить ей 
//значение и вывести это значение на печать.

//Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском 
//счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру 
//значениями и напечатать результат.

//Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать 
//структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и 
//распечатать.

using System;

namespace EnumExample
{
    enum BankAcc
    {
        Current=0, // Текущий счёт
        Savings=1  // Сберегательный счёт
    }
    struct BankAccount
    {
        public string AccountNumber; // Номер счета
        public BankAcc AccountType;   // Тип счета
        public decimal Balance;      // Баланс счета
       
    // Создание счета
        public BankAccount(string accountNumber, BankAcc accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }

    // Для печати информации о счете
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Тип счета: {AccountType}");
            Console.WriteLine($"Баланс: {Balance:C}");
        }
    }

    enum University
    {
        KGU,  // Казанский Государственный Университет
        KAI,  // Казанский Авиастроительный Институт
        KHTI  // Казанский Химико-Технологический Институт
    }

    struct Employee
    {
        public string Name;           // Имя работника
        public University University; // Университет

        // Вывод информации о работнике
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"ВУЗ: {University}");
        }
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


            Console.WriteLine("упражнение 3.2");
            // Создание счета
            BankAccount account = new BankAccount("123456789", BankAcc.Savings, 1500.75m);

            // Печать информации о счете
            account.PrintAccountInfo();
            
            
            Console.WriteLine("домашнее задание 3.1");
            // Создание структуры, заполнение значениями
            Employee employee = new Employee
            {
                Name = "Иван Иванов",
                University = University.KGU
            };

            // Вывод информации
            employee.PrintInfo();
        }
    }
}


