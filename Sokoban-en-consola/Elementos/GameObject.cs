using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    public class GameObject
    {
        public Posicion posicion = null;
        public virtual char MostrarElemento() { return ' '; }
        public virtual bool PuedoCaminar() { return true; }     
        public virtual bool PuedoEmpujar() { return true; }
        public virtual bool PuedeMoverse() { return true; }
    }
}
