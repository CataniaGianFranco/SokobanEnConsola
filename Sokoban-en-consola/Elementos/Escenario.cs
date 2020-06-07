using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    class Escenario
    {
        public virtual char MostrarElemento()
        {
            return ' ';
        }
        public virtual bool PuedoCaminar()
        {
            return PuedoCaminar(); 
        }
    }
}
