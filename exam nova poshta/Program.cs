//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


using System.Diagnostics;
using System.Xml.Linq;

Console.WriteLine("--------- Welcome to Nova Poshta! ---------");
Console.WriteLine("\tMail Services\n" +
    "1. Add new service\n" +
    "2. Save service\n" +
    "3. Edit sertvice\n" +
    "4. Show all service\n" +
    "5. Find service\n" +
    "6. Delete service\n");
Console.WriteLine("-------------------------------------------");

Console.Write("your choice: ");
int choice = int.Parse(Console.ReadLine());

Package item = null;

switch (choice)
{
    case 1:
        item.ReadFromConsole();
        break;

    case 4:
        item.Show();
        break;
}

Console.ReadKey();

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
        Phone = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Number: {Number}$");
        Console.WriteLine($"CityTo: {Date}");
        Console.WriteLine($"Number: {Phone}");
        Console.WriteLine($"CityFrom: {CityFrom}");
        Console.WriteLine($"CityTo: {CityTo}");
    }
}
