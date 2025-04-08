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

Menu menu = new();
nova_poshta exam_nova_poshta = new();

menu.ShowLoginMenu();
int roleChoice = menu.AskUserInput();

if (roleChoice == 1)
{
    Console.Clear(); // очищення консолі
    Console.WriteLine("------------- Welcome to Nova Poshta for User! -------------");

    menu.ShowUserMenu();
    int choice = menu.AskUserInput();

    switch (choice)
    {
        case 0: return 0;
        case 1:
            Console.WriteLine("You can buy something!");
            break;
    }
}

if (roleChoice == 2)
{



    while (true)
    {
        Console.Clear();
        Console.WriteLine("--------- Welcome to Nova Poshta! ---------");

        menu.ShowAdminMenu();
        int choice = menu.AskUserInput();


        switch (choice)
        {
            case 0:
                Console.WriteLine("Have a great day!");
                return 0;

            case 1: exam_nova_poshta.AddPackage(); break;

            case 2: exam_nova_poshta.AddService(); break;

            case 3: exam_nova_poshta.ShowPackage(); break;

            case 4: exam_nova_poshta.ShowService(); break;

            case 5: exam_nova_poshta.LoadService(); break;

            case 6: exam_nova_poshta.SaveService(); break;

            case 7: exam_nova_poshta.FindService(); break;

            case 8: exam_nova_poshta.DeleteService(); break;
        }

        Console.ReadKey();
        Console.ReadKey();
    }

}

Console.WriteLine("Have a nice day!");
return 0;