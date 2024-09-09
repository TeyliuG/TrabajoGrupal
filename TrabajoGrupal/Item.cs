using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupal
{

    internal class Item
    {
        private string name;
        private int price;
        private int type;
        
        public Item(string name,int price,int type)
        {
            this.name = name;
            this.price = price;
            this.type = type;

        }

    }
}
