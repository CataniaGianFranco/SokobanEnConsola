using Sokoban_en_consola.Elementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola
{
    class Nivel
    {
        public Nivel() { }
        
        Escenario[,] escenario;
        
        public void Nivel_01()
        {
            escenario = new Escenario[3, 3];

            escenario[0, 0] = new Pared(); escenario[0, 1] = new Pared(); escenario[0, 2] = new Pared();
            escenario[1, 0] = new Pared(); escenario[1, 1] = new Piso();  escenario[1, 2] = new Pared();
            escenario[2, 0] = new Pared(); escenario[2, 1] = new Pared();  escenario[2, 2] = new Pared();

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(escenario[fila, columna].MostrarElemento());
                }
                Console.WriteLine();
            }
        }
    }
}
