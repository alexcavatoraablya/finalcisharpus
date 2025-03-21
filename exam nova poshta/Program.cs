//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


using System.Diagnostics;
using System.Numerics;
using System.Text.Json;
using System.Xml.Linq;

List<Package> items = new()
{
    new Package() { Number = 056, Date = "03 10", Phone = "0973609912", CityFrom = "Kuiv", CityTo = "Rivne"},
    new Package() { Number = 057, Date = "03 10", Phone = "0973609912", CityFrom = "Kuiv", CityTo = "Zhitomur"},
    new Package() { Number = 058, Date = "03 10", Phone = "0973609912", CityFrom = "Kuiv", CityTo = "Harkiv"},
};

List<Service> services = new()
{
    new Service() { Name = "Sending", Duration = 2, Price = 140 },
    new Service() { Name = "Global Forvarding", Duration = 10, Price = 290 },
};

while (true)
{
    Console.WriteLine("--------- Welcome to Nova Poshta! ---------");
    Console.WriteLine("\tMail Services\n" +
        "1. Add new package\n" +
        "2. Add new service\n" +
        "3. Show all package\n" +
        "4. Show all service\n" +
        "5. Load services\n" +
        "6. Find service\n" +
        "7. Delete service\n");
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

        case 2:
            Service newService = new();
            newService.ReadFromConsole();
            services.Add(newService);
            break;

        case 3:
            foreach (Package item in items)
                item.Show();
            break;

        case 4:
            foreach (Service service in services)
                service.Show();
            break;

        case 5:
            var jsonData = File.ReadAllText("database.json");
            services = JsonSerializer.Deserialize<List<Service>>(jsonData);
            break;

        case 6:
            Console.WriteLine("Enter service to find: ");
            string name = Console.ReadLine();

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