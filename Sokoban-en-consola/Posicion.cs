using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola
{
    public class Posicion
    {
        private int fila;
        private int columna;

        public Posicion() { }
        public Posicion (int pFila, int pColumna)
        {
            this.fila = pFila;
            this.columna = pColumna;
        }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public void MostrarPosicion()
        {
            Console.WriteLine("Posicion Fila: {0} y Columna: {1}", fila, columna);
        }       
    }
}
