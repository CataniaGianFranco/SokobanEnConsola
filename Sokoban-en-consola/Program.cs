﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Nivel nivel = new Nivel();
            nivel.Nivel_01();

            Console.ReadKey();
        }
    }
}
