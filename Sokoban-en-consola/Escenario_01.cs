using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sokoban_en_consola.Elementos;

namespace Sokoban_en_consola
{
    public class Escenario_01 : GameObject
    {
        GameObject[,] gameObject = new GameObject[4, 4];

        public void Inicio()
        {
            CargarEscenario();
            MostrarEscenario();
        }
        private void CargarEscenario()
        {
            //Se carga los objetos a cada posición.
            gameObject[0, 0] = new Pared(); gameObject[0, 1] = new Pared();   gameObject[0, 2] = new Pared(); gameObject[0, 3] = new Pared();
            gameObject[1, 0] = new Pared(); gameObject[1, 1] = new Jugador(); gameObject[1, 2] = new Piso();  gameObject[1, 3] = new Pared();
            gameObject[2, 0] = new Pared(); gameObject[2, 1] = new Piso();    gameObject[2, 2] = new Piso();  gameObject[2, 3] = new Pared();
            gameObject[3, 0] = new Pared(); gameObject[3, 1] = new Pared();   gameObject[3, 2] = new Pared(); gameObject[3, 3] = new Pared();
        }
        private void MostrarEscenario()
        {
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.Write(gameObject[fila,columna].MostrarElemento() );
                }
                Console.WriteLine();
            }
        }
    }
}
