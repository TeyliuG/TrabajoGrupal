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
        
        public Item(string name)
        {
            this.name = name;

        }
        public string GetSet()
        {
            return $"Item:{name}";
        }
    }
}
