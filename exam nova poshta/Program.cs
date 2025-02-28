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
    "3. Load service\n" +
    "4. Show all service\n" +
    "5. Find service\n" +
    "6. Delete service\n");
Console.WriteLine("-------------------------------------------");

public class Package
{
    public string Receipt { get; set; }
    public string Receiving { get; set; }
    public int Payment { get; set; }
    public string Registration { get; set; }

}