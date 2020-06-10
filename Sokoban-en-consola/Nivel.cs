using Sokoban_en_consola.Elementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola
{
    public class Nivel
    {
        public Nivel() { }

        Escenario_01 escenario_01 = new Escenario_01();
        public void CargarEscenario_01()
        {
            escenario_01.Inicio();
        }
    }
}