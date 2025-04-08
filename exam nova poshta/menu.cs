using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_nova_poshta;
internal class Menu
{
    public void ShowAdminMenu()
    {
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
    }

    public int AskUserInput()
    {
        Console.Write("Your choice: ");
        return int.Parse(Console.ReadLine());
    }

    public void ShowLoginMenu()
    {
        Console.WriteLine("\tChoose your role\n" +
       "0. Exit\n" +
       "1. User\n" +
       "2. Admin\n");
        Console.WriteLine("-------------------------------------------");
    }

    public void ShowUserMenu()
    {
        Console.WriteLine("\tUSER MENU\n" +
                          "0. Exit\n" +
                          "1. Add delivery");
        Console.WriteLine("-------------------------------------------");
    }
}