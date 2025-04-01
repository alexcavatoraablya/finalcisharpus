//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


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
