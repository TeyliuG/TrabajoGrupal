using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupal
{
    internal class Jugador
    {
        private string name;
        private int level;

        public Jugador(string name, int level)
        {
            this.name = name;
            this.level = level;

        }
        public string GetData()
        {
            return $"Jugador:{name} - Nivel:{level}";
        }
    }
}   
