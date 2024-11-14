using System;

namespace univ{
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

        // Метод для вывода информации о работнике
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
            // Создаем и заполняем структуру значениями
            Employee employee = new Employee
            {
                Name = "Иван Иванов",
                University = University.KGU
            };

            // Выводим информацию о работнике
            employee.PrintInfo();
        }
    }
}