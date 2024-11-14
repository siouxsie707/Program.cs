//Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать 
//структуру работник с двумя полями: имя, ВУЗ. Заполнить структуру данными и 
//распечатать.
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