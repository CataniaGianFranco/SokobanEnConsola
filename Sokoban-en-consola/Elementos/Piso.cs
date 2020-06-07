using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    class Piso : Escenario
    {
        public override char MostrarElemento()
        {
            return ' ';
        }
        public override bool PuedoCaminar()
        {
            return true;
        }
    }
}
