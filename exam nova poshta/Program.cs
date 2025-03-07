//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


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
        item = new Package();
        item.Number = int.Parse(Console.ReadLine());
        item.Date = Console.ReadLine();
        item.Phone = Console.ReadLine();
        item.CityFrom = Console.ReadLine();
        item.CityTo = Console.ReadLine();
        break;

    case 4:
        Console.WriteLine($"Number: { item.Number }");
        Console.WriteLine($"CityTo: { item.CityTo }");
        break;
}

public class Package
{
    public int Number { get; set; }
    public string Date { get; set; }
    public string Phone { get; set; }
    public string CityFrom { get; set; }
    public string CityTo { get; set; }
}
