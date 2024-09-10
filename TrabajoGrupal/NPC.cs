using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupal
{
    internal class NPC
    {
        private static List<NPC> NPCs = new List<NPC>();
        private string Name { get; set; }
            private int Level { get; set; }

            public NPC(string name, int level)
            {
                Name = name;
                Level = level;
            }
        public static void AddNPC(string name, int level)
        {
            var npc = new NPC(name, level);
            NPCs.Add(npc);
        }
        public static void ListNPCs()
        {
            if (NPCs.Count == 0)
            {
                Console.WriteLine("No hay npcs");
                return;
            }

            foreach (var npc in NPCs)
            {
                Console.WriteLine(npc);
            }
        }

    }
}



