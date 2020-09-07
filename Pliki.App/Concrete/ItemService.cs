using Pliki.App.Abstract;
using Pliki.App.Common;
using Pliki.Domain;
using Pliki.Domain.Entity;
using Pliki.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace Pliki.App.Concerte

{
    public class ItemService :BaseService<Item>
    {





        public void ItemDetalView(int detailId)
        {
            Item productToShow = new Item(1,"",1);
            foreach (var item in Items)
            {
                if (item.Id == detailId)
                {
                    productToShow = item;
                    break;
                }
            }
            Console.WriteLine($"Id pliku: {productToShow.Id}");
            Console.WriteLine($"Nazwa pliku: {productToShow.Name}");
            Console.WriteLine($"Typ pliku: {productToShow.TypeId}");
        }

        public void ItemsByTypeIdView(int typeId)
        {
            List<Item> toShow = new List<Item>();
            foreach (var item in Items)
            {
                if (item.TypeId == typeId)
                {
                    toShow.Add(item);
                }

            }

            Console.WriteLine(toShow.ToStringTable(new[] { "Id", "Name" }, a => a.Id, async => async.Name));
        }

        public int ItemTypeSeleCtionView()
        {
            Console.WriteLine("Podaj id typu pliku do obejrzenia");
            var ItemId = Console.ReadKey();
            int id;
            Int32.TryParse(ItemId.KeyChar.ToString(), out id);

            return id;
        }

        public int ItemDetalSelectionView()
        {
            Console.WriteLine("Podaj id pliku do obejrzenia");
            var ItemId = Console.ReadKey();
            int id;
            Int32.TryParse(ItemId.KeyChar.ToString(), out id);

            return id;
        }




    }

}




