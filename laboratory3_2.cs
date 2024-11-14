//Упражнение 3.2 Создать структуру данных, которая хранит информацию о банковском 
//счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру 
//значениями и напечатать результат.
using System;
namespace bank
{
    
    struct BankAccount
    {
        public string AccountNumber; // Номер счета
        public string AccountType;   // Тип счета
        public decimal Balance;      // Баланс счета

    // Создание счета
    public BankAccount(string accountNumber, string accountType, decimal balance)
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


    class Program
    {
        static void Main()
        {   
            Console.WriteLine("упражнение 3.2");
            // Создание счета
            BankAccount account = new BankAccount("123456789", "Сберегательный", 1500.75m);

            // Печать информации о счете
            account.PrintAccountInfo();
        }
    }
}