//Написать программу, содержащую решение следующих задач: 
//1. Выведите на экран информацию о каждом типе данных в виде: 
//Тип данных – максимальное значение – минимальное значение 
//2. Напишите программу, в которой принимаются данные пользователя в виде имени, 
//города, возраста и PIN-кода. Далее сохраните все значение в соответствующей 
//переменной, а затем распечатайте всю информацию в правильном формате. 
//3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на 
//строчные.
//4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести 
//на экран. 
//5. Цель этой задачи - определить, сколько бутылок виски беспошлинной торговли вам 
//нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически 
//покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена (normPrice), 
//скидка в Duty Free (salePrice) и стоимость отпуска (holidayPrice). Например, если бутылка 
//обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10%, вы 
//сэкономите 1 фунт стерлингов на каждой бутылке. Если ваш отпуск стоит 500 фунтов 
//стерлингов, ответ, который вы должны вернуть, будет 500. Все входные данные будут 
//целыми числами. Пожалуйста, верните целое число. Округлить в меньшую сторону. 
//6. Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата 
//рождения, Категория алкоголизма (a – студент алкоголик, b – студент любитель 
//выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у 
//студента есть Объем выпитой жидкости конкретного напитка. Создать 5 студентов с 
//различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя 
//(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества 
//выпил. Предполагается, что студент пьет один вид напитка. Напитки задать в виде 
//структуры: наименование типа напитка и процент спирта.
using System;

struct Drink
{
    public string Name;
    public double AlcoholPercent;

    public Drink(string name, double alcoholPercent)
    {
        Name = name;
        AlcoholPercent = alcoholPercent;
    }
}

struct Student
{
    public string LastName;
    public string FirstName;
    public int ID;
    public DateTime BirthDate;
    public char AlcoholCategory;
    public double VolumeConsumed;
    public Drink DrinkType;

    public Student(string lastName, string firstName, int id, DateTime birthDate, char alcoholCategory, double volumeConsumed, Drink drinkType)
    {
        LastName = lastName;
        FirstName = firstName;
        ID = id;
        BirthDate = birthDate;
        AlcoholCategory = alcoholCategory;
        VolumeConsumed = volumeConsumed;
        DrinkType = drinkType;
    }

    public double CalculatePureAlcohol() => VolumeConsumed * (DrinkType.AlcoholPercent / 100);
}

class Program
{
    static void InputUserInfo()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш город: ");
        string city = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите PIN-код: ");
        int pinCode = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nИмя: {name}\nГород: {city}\nВозраст: {age}\nPIN-код: {pinCode}");
    }

    static void SwapCaseString()
    {
        Console.Write("Введите строку для преобразования: ");
        string input = Console.ReadLine();

        string result = "";
        foreach (char c in input)
        {
            result += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }
        
        Console.WriteLine("Преобразованная строка: " + result);
    }

    static void CountSubstringOccurrences()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        Console.Write("Введите подстроку: ");
        string substring = Console.ReadLine();

        int count = 0;
        int index = 0;
        
        while ((index = inputString.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length;
        }

        Console.WriteLine("Количество вхождений подстроки \"{substring}\" в строку: {count}");
    }

    static void CalculateBottles()
    {
        Console.Write("Введите стандартную цену (normPrice): ");
        int normPrice = int.Parse(Console.ReadLine());

        Console.Write("Введите скидку в Duty Free (в процентах): ");
        int saleDiscount = int.Parse(Console.ReadLine());

        Console.Write("Введите стоимость отпуска (holidayPrice): ");
        int holidayPrice = int.Parse(Console.ReadLine());

        double discountAmount = normPrice * (saleDiscount / 100.0);
        int bottlesNeeded = (int)Math.Floor(holidayPrice / discountAmount);

        Console.WriteLine($"Необходимое количество бутылок: {bottlesNeeded}");
    }

    static void StudentDataAnalysis()
    {
        Drink beer = new Drink("Пиво", 5);
        Drink wine = new Drink("Вино", 12);
        Drink vodka = new Drink("Водка", 40);Student[] students = new Student[]
        {
            new Student("Иванова", "Ольга", 1, new DateTime(2004, 1, 15), 'a', 2000, beer),
            new Student("Петров", "Петр", 2, new DateTime(2005, 5, 10), 'b', 1500, wine),
            new Student("Сидоров", "Сидр", 3, new DateTime(2001, 7, 20), 'c', 500, vodka),
            new Student("Ленина", "Нинель", 4, new DateTime(2003, 3, 25), 'd', 0, beer),
            new Student("Митаева", "Лилиана", 5, new DateTime(2002, 12, 30), 'c', 700, wine)
        };

        double totalVolume = 0;
        double totalPureAlcohol = 0;

        foreach (Student student in students)
        {
            totalVolume += student.VolumeConsumed;
            totalPureAlcohol += student.CalculatePureAlcohol();
        }

        Console.WriteLine($"Общий объем выпитой жидкости: {totalVolume} мл");
        Console.WriteLine($"Общий объем чистого алкоголя: {totalPureAlcohol:F2} мл");

        foreach (Student student in students)
        {
            double studentAlcoholPercentage = (student.CalculatePureAlcohol() / totalPureAlcohol) * 100;
            double studentVolumePercentage = (student.VolumeConsumed / totalVolume) * 100;
            Console.WriteLine($"{student.FirstName} {student.LastName} выпил {studentVolumePercentage:F2}% жидкости и {studentAlcoholPercentage:F2}% алкоголя от общего количества.");
        }
    }
    static void ShowDataTypeInfo()
        {
            Console.WriteLine("Тип данных – Максимальное значение – Минимальное значение");
            Console.WriteLine($"int – {int.MaxValue} – {int.MinValue}");
            Console.WriteLine($"double – {double.MaxValue} – {double.MinValue}");
            Console.WriteLine($"float – {float.MaxValue} – {float.MinValue}");
            Console.WriteLine($"decimal – {decimal.MaxValue} – {decimal.MinValue}");
            Console.WriteLine($"long – {long.MaxValue} – {long.MinValue}");
            Console.WriteLine($"short – {short.MaxValue} – {short.MinValue}");
        }
    static void Main()
    {
        Console.WriteLine("домашнее задание");
        ShowDataTypeInfo();
        InputUserInfo();
        SwapCaseString();
        CountSubstringOccurrences();
        CalculateBottles();
        StudentDataAnalysis();
    }
    
}
   

