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

        public Posicion (int pFila, int pColumna)
        {
            fila = pFila;
            columna = pColumna;
        }

        
        public int Fila
        {
            get => fila; set => fila = value;
        }
        public int Columna
        {
            get => columna; set => columna = value;
        }
    }
}
