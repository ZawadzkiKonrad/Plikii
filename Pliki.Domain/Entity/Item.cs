using Pliki.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pliki.Domain.Entity

{
 

 
    public class Item : BaseEntity
    {
       
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int LastId { get; set; }
        public int Quantity { get; set; }
        protected bool isLowInWarehouse;

        public Item(int id, string name, int typeId)
        {
            Name = name;
            TypeId = typeId;
        }

        public Item(int removeId)
        {

        }

    }
   
}
