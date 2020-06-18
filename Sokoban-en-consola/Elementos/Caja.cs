using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    public class Caja : GameObject
    {
        public override bool PuedeMoverse() { return true; }
        public override bool PuedoCaminar() { return false; }
        public override bool PuedoEmpujar() { return true; }
        public override char MostrarElemento() { return 'o'; }
    }
}
