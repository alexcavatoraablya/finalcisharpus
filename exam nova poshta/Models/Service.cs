//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


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