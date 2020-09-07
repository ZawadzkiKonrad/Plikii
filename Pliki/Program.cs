using Pliki.App.Abstract;
using Pliki.App.Concerte;
using Pliki.App.Menagers;
using Pliki.Domain.Entity;
using System;
using Warehouse;


//29:21


namespace Pliki.App
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();
            ItemMenager itemMenager = new ItemMenager(actionService,itemService);
                     
            Console.WriteLine("Witaj!!!");
            while (true)
            {

            
            Console.WriteLine("Wwybierz co chcesz zrobić z plikiem");
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}.  {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
                Console.Clear();
            switch(operation.KeyChar)
            {
                case '1':
                        itemMenager.AddNewItem();
                        break;

                case '2':
                        itemMenager.RemoveItem();
                         break;
                    case '3':
                        itemMenager.ItemsByTypeIdView();
                        break;
                    case '4':
                        //var typeId = itemService.ItemTypeSeleCtionView();
                        //itemService.ItemsByTypeIdView(typeId);
                        //break;
                    default:
                    Console.WriteLine("nieprawidłowa akcja!!");
                    break;

            }
                
        }
        }

     
    }
}
