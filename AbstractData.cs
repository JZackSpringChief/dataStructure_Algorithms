//What is abstract data type -- a "Class";
//example is CRUD - create, read, update, delete;
//Reperesention and Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructure
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; }
        public int DexNum { get; set; }

        public bool IsPokemon()
        {
            return true;
        }
    }
}
