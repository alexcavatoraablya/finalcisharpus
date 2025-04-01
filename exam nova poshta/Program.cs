//Нова пошта
//	Вивід послуг пошти
//	Доповнення(редагування, видалення ) послуги
//  Прийом замовлення про пересилку товару(друк квитанції, прийом товару, оплата, реєстрація про замовлення у базі) 
//	Відмітка про виконання замовлення(доставку товарів)
//	Зберігати та завантажувати у(з) файлі(у) замовлені послуги
//	Виконані послуги зберігати у іншому файлі


using exam_nova_poshta;
using System.Diagnostics;
using System.Numerics;
using System.Text.Json;
using System.Xml.Linq;

nova_poshta exam_nova_poshta = new();

while (true)
{
    Console.WriteLine("--------- Welcome to Nova Poshta! ---------");
    Console.WriteLine("\tMail Services\n" +
        "0. Exit\n" +
        "1. Add new package\n" +
        "2. Add new service\n" +
        "3. Show all package\n" +
        "4. Show all service\n" +
        "5. Load services\n" +
        "6. Save service\n" +
        "7. Find service\n" +
        "8. Delete service\n");
    Console.WriteLine("-------------------------------------------");

    Console.Write("your choice: ");
    int choice = int.Parse(Console.ReadLine());



    switch (choice)
    {
        case 0:
            Console.WriteLine("Have a great day!");
            return 0;

        case 1:
            
            break;

        case 2:
           
            break;

        case 3:

            break;

        case 4:

            break;

        case 5:
           
            break;

        case 6:
            
            break;

        case 7:

            break;

        case 8:

            break;
    }

    Console.ReadKey();
    Console.ReadKey();
}
