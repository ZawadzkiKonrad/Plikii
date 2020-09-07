using Pliki.App.Abstract;
using Pliki.App.Concerte;
using Pliki.Domain.Entity;
using Pliki.App;
using System;
using System.Collections.Generic;
using System.Text;
using Pliki.Helpers;
using Pliki.App.Common;

namespace Pliki.App.Menagers
{
   public class ItemMenager: BaseService<Item>
    {
        private readonly MenuActionService _actionService;
        public IService<Item> _itemService;



        public new List<Item> Items { get; set; } = new List<Item>();
        


        public ItemMenager(MenuActionService actionService, IService<Item> itemService)
        {
            _itemService = itemService;
            _actionService = actionService;
        }

        public ItemMenager(MenuActionService actionService)
        {
            _actionService = actionService;

        }
        public void AddNewItem()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("Wybierz typ pliku:");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            int lastId = _itemService.GetLastId();
            var operation = Console.ReadKey();
            Int32.TryParse(operation.KeyChar.ToString(), out int typeId);
            Console.WriteLine("Podaj nazwe pliku:");
            var name = Console.ReadLine();
            
            Item item = new Item(lastId,name.ToString(), typeId);
            
            Items.Add(item);
           
            
        }

       
       public void RemoveItem()

        {
            Console.WriteLine("Podaj id pliku do usunięcia:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.ToString(), out id);
            Item productToRemove = new Item(1, "",1);
            foreach (var item in Items)
            {
                if (item.Id == id)
                {
                    productToRemove = item;
                    break;
                }
            }
            Items.Remove(productToRemove);
        }

        public void ItemsByTypeIdView()
        {
            Console.WriteLine("Podaj id typu plików do wysiwetlenia:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);
            List<Item> toShow = new List<Item>();
            foreach (var item in Items)
            {
                if (item.TypeId == id)
                {
                    toShow.Add(item);
                }

            }

            Console.Write(toShow.ToStringTable(new[] { "Id", "Name" }, a => a.Id, async => async.Name));
        }

       
    }
}
