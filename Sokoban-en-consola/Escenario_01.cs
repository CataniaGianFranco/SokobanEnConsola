using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Sokoban_en_consola.Elementos;

namespace Sokoban_en_consola
{
    public class Escenario_01 : GameObject
    {
        GameObject[,] gameObject = new GameObject[8, 8];
        GameObject jugador = null;
        Posicion posicionamiento = null;
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        private void Inicio()
        {
            CargarGameObjects();
            CargarPosicion();
            jugador = gameObject[4, 4];
            MostrarEscenario();

        }
        public void Actualizar()
        {
            Inicio();
            LeerInput();
        }
        private void CargarGameObjects()
        {
            //Se carga los objetos a cada posición.
            gameObject[0, 0] = new Vacio(); gameObject[0, 1] = new Vacio();   gameObject[0, 2] = new Pared(); gameObject[0, 3] = new Pared(); gameObject[0, 4] = new Pared();   gameObject[0, 5] = new Vacio();  gameObject[0, 6] = new Vacio(); gameObject[0, 7] = new Vacio();
                                                               
            gameObject[1, 0] = new Vacio(); gameObject[1, 1] = new Vacio();   gameObject[1, 2] = new Pared(); gameObject[1, 3] = new Destino();  gameObject[1, 4] = new Pared();   gameObject[1, 5] = new Vacio();  gameObject[1, 6] = new Vacio(); gameObject[1, 7] = new Vacio();
                                                               
            gameObject[2, 0] = new Vacio(); gameObject[2, 1] = new Vacio();   gameObject[2, 2] = new Pared(); gameObject[2, 3] = new Piso();  gameObject[2, 4] = new Pared();   gameObject[2, 5] = new Pared();  gameObject[2, 6] = new Pared(); gameObject[2, 7] = new Pared();
            
            gameObject[3, 0] = new Pared(); gameObject[3, 1] = new Pared();   gameObject[3, 2] = new Pared(); gameObject[3, 3] = new Caja();  gameObject[3, 4] = new Piso();    gameObject[3, 5] = new Caja();   gameObject[3, 6] = new Destino(); gameObject[3, 7] = new Pared();
           
            gameObject[4, 0] = new Pared(); gameObject[4, 1] = new Destino();   gameObject[4, 2] = new Piso(); gameObject[4, 3] = new Caja();   gameObject[4, 4] = new Jugador(); gameObject[4, 5] = new Piso();   gameObject[4, 6] = new Pared(); gameObject[4, 7] = new Pared();
           
            gameObject[5, 0] = new Pared(); gameObject[5, 1] = new Pared();   gameObject[5, 2] = new Pared(); gameObject[5, 3] = new Pared(); gameObject[5, 4] = new Pared();   gameObject[5, 5] = new Caja();   gameObject[5, 6] = new Pared(); gameObject[5, 7] = new Vacio();
           
            gameObject[6, 0] = new Vacio(); gameObject[6, 1] = new Vacio();   gameObject[6, 2] = new Vacio(); gameObject[6, 3] = new Vacio(); gameObject[6, 4] = new Pared();   gameObject[6, 5] = new Destino();   gameObject[6, 6] = new Pared(); gameObject[6, 7] = new Vacio();
           
            gameObject[7, 0] = new Vacio(); gameObject[7, 1] = new Vacio();   gameObject[7, 2] = new Vacio(); gameObject[7, 3] = new Vacio(); gameObject[7, 4] = new Pared();   gameObject[7, 5] = new Pared();  gameObject[7, 6] = new Pared(); gameObject[7, 7] = new Vacio();

        }
        private void CargarPosicion()
        {
            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    gameObject[fila, columna].posicion = new Posicion(fila, columna);
                }
            }
        }
        private void MostrarEscenario()
        {       
            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    Console.Write(gameObject[fila,columna].MostrarElemento() );
                }
                Console.WriteLine();
            }
        }
        private void LeerInput()
        {
            do
            {
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.RightArrow:
                        posicionamiento = new Posicion(0, 1);      
                        break;

                    case ConsoleKey.LeftArrow:
                        posicionamiento = new Posicion(0, -1);
                        break;

                    case ConsoleKey.UpArrow:
                        posicionamiento = new Posicion(-1, 0);
                        break;

                    case ConsoleKey.DownArrow:
                        posicionamiento = new Posicion(1, 0);
                        break;

                    default:
                         throw new Exception();
                }
                Console.Clear();
                ActualizarJugador(posicionamiento.Fila,posicionamiento.Columna);
                CargarPosicion();
                MostrarEscenario();
            } while (tecla.Key != ConsoleKey.Enter);   
        }
        private void ActualizarJugador(int pFila, int pColumna)
        {
            
            if (jugador.PuedoCaminar() == gameObject[jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna].PuedoCaminar())
            {
                jugador.posicion = new Posicion(jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna);
                gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                gameObject[jugador.posicion.Fila - pFila, jugador.posicion.Columna - pColumna] = new Piso();
            }
            // Si jugador puede empujar, y la caja puede ser empujado y ademas si puede moverse mientras la posicion adelante sea piso.
            else if (jugador.PuedoEmpujar() == gameObject[jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna].PuedoEmpujar()
                && gameObject[jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna].PuedeMoverse() == gameObject[jugador.posicion.Fila + pFila * 2, jugador.posicion.Columna + pColumna *2].PuedoCaminar())
            {
                jugador.posicion = new Posicion(jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna);
                gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                gameObject[jugador.posicion.Fila + pFila, jugador.posicion.Columna + pColumna] = new Caja();
                gameObject[jugador.posicion.Fila - pFila, jugador.posicion.Columna - pColumna] = new Piso();
            }
        }
    }
}