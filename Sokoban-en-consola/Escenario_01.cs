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
        GameObject jugador = null;
        ConsoleKeyInfo tecla = new ConsoleKeyInfo();
        private void Inicio()
        {
            CargarGameObjects();
            CargarPosicion();
            jugador = gameObject[1, 1];
            MostrarEscenario();

        }
        public void Actualizar()
        {
            Inicio();
            MoverJugador();
        }
        private void CargarGameObjects()
        {
            //Se carga los objetos a cada posición.
            gameObject[0, 0] = new Pared(); gameObject[0, 1] = new Pared();   gameObject[0, 2] = new Pared(); gameObject[0, 3] = new Pared();
            gameObject[1, 0] = new Pared(); gameObject[1, 1] = new Jugador(); gameObject[1, 2] = new Piso();  gameObject[1, 3] = new Pared();
            gameObject[2, 0] = new Pared(); gameObject[2, 1] = new Piso();    gameObject[2, 2] = new Piso();  gameObject[2, 3] = new Pared();
            gameObject[3, 0] = new Pared(); gameObject[3, 1] = new Pared();   gameObject[3, 2] = new Pared(); gameObject[3, 3] = new Pared();            
        }
        private void CargarPosicion()
        {
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    gameObject[fila, columna].posicion = new Posicion(fila, columna);
                }
            }
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
        private void MoverJugador()
        {
            do
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    jugador.posicion = new Posicion(jugador.posicion.Fila, jugador.posicion.Columna + 1);
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna - 1] = new Piso();
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    jugador.posicion = new Posicion(jugador.posicion.Fila, jugador.posicion.Columna -1);
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna + 1] = new Piso();
                }
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    jugador.posicion = new Posicion(jugador.posicion.Fila - 1, jugador.posicion.Columna);
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                    gameObject[jugador.posicion.Fila + 1, jugador.posicion.Columna] = new Piso();
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    jugador.posicion = new Posicion(jugador.posicion.Fila + 1, jugador.posicion.Columna);
                    gameObject[jugador.posicion.Fila, jugador.posicion.Columna] = jugador;
                    gameObject[jugador.posicion.Fila - 1, jugador.posicion.Columna] = new Piso();
                }
                MostrarEscenario();
            } while (tecla.Key != ConsoleKey.Enter);
            
            
        }
    }
}