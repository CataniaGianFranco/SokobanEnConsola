﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
      class Pared : Escenario
      {
        public override char MostrarElemento()
        {
            return '#';
        }
        public override bool PuedoCaminar()
        {
            return false;
        }
      }
}
