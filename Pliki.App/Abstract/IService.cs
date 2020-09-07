using System;
using System.Collections.Generic;
using System.Text;

namespace Pliki.App.Abstract
{
   public interface IService<T>
    {
        List<T> Items { get; set; }
        List<T> getAllItems();
        int AddItem(T item);
        int EditItem(T item);
        void RemoveItem(T item);
        int GetLastId();
        T GetItemById(int id);
    }
}
