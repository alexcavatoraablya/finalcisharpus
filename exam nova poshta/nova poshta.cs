using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace exam_nova_poshta
{
    internal class nova_poshta
    {
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


        public void AddPackage()
        {
            Package newItem = new();
            newItem.ReadFromConsole();
            items.Add(newItem);
        }
        public void AddService()
        {
            Service newService = new();
            newService.ReadFromConsole();
            services.Add(newService);
        }
        public void ShowPackage()
        {
            foreach (Package item in items)
                item.Show();
        }
        public void ShowService()
        {
            foreach (Service service in services)
                service.Show();
        }
        public void LoadService()
        {
            var jsonData = File.ReadAllText("database.json");
            services = JsonSerializer.Deserialize<List<Service>>(jsonData);
        }
        public void SaveService()
        {
            var json = JsonSerializer.Serialize(items);
            File.WriteAllText("database.json", json);

            var json2 = JsonSerializer.Serialize(services);
            File.WriteAllText("services.json", json2);
        }
        public void FindService()
        {
            Console.WriteLine("Enter service to find: ");
            string name = Console.ReadLine();
        }
        public void DeleteService()
        {
            Console.Write("Enter service to delete: ");
            int name2 = int.Parse(Console.ReadLine());

            var found2 = items.Find(x => x.Number == name2);
            if (found2 == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            items.Remove(found2);
        }
    }
}
