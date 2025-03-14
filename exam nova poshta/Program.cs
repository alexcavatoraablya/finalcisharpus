﻿//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<Package> items = new();
List<Service> services = new();

while (true)
{
    Console.WriteLine("--------- Welcome to Nova Poshta! ---------");
    Console.WriteLine("\tMail Services\n" +
        "1. Add new package\n" +
        "2. Add new service\n" +
        "3. Show all package\n" +
        "4. Show all service\n" +
        "5. Find service\n" +
        "6. Delete service\n");
    Console.WriteLine("-------------------------------------------");

    Console.Write("your choice: ");
    int choice = int.Parse(Console.ReadLine());



    switch (choice)
    {
        case 1:
            Package newItem = new();
            newItem.ReadFromConsole();
            items.Add(newItem);
            break;

        case 4:
            foreach (Package item in items)
                item.Show();
            break;
        case 2:
            Service newService = new();
            newService.ReadFromConsole();
            services.Add(newService);
            break;

        case 3:
            foreach (Package item in items)
                item.Show();
            break;
    }

    Console.ReadKey();
}

public class Package
{
    public int Number { get; set; }
    public string Date { get; set; }
    public string Phone { get; set; }
    public string CityFrom { get; set; }
    public string CityTo { get; set; }

    public void ReadFromConsole()
    {
        Console.Write("Enter number: ");
        Number = int.Parse(Console.ReadLine());
        Console.Write("Enter city to: ");
        CityTo = Console.ReadLine();
        Console.Write("Enter city from: ");
        CityFrom = Console.ReadLine();
        Console.Write("Enter phone: ");
        Phone = Console.ReadLine();
        Console.Write("Enter date: ");
        Date = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Number: {Number}");
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"City from: {CityFrom}");
        Console.WriteLine($"City to: {CityTo}");
    }
}
public class Service
{
    public double Price { get; set; }
    public int Duration { get; set; }
    public string Name { get; set; }
    
    public void ReadFromConsole()
    {
        Console.Write("Enter name: ");
        Name = Console.ReadLine();
        Console.Write("Enter duration: ");
        Duration = int.Parse(Console.ReadLine());
        Console.Write("Enter price: ");
        Price = double.Parse(Console.ReadLine());
    }
    public void Show()
    {
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Price: {Price}");
    }
}