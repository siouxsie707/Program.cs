using System;
namespace bank
{
    
    struct BankAccount
    {
        public string AccountNumber; // Номер счета
        public string AccountType;   // Тип счета (например, "Сберегательный", "Текущий")
        public decimal Balance;      // Баланс счета

    // Конструктор для удобного создания счета
    public BankAccount(string accountNumber, string accountType, decimal balance)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        Balance = balance;
    }

    // Метод для печати информации о счете
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
            // Создание и инициализация банковского счета
            BankAccount account = new BankAccount("123456789", "Сберегательный", 1500.75m);

            // Печать информации о счете
            account.PrintAccountInfo();
        }
    }
}