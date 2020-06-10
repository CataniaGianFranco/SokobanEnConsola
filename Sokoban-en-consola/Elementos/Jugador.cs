using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    public class Jugador : GameObject
    {
        public override char MostrarElemento() { return 'x'; }
        public override bool PuedoCaminar() { return true; }    
    }
}
