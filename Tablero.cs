using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    class Tablero
    {
        protected int[] _tablero;
        /// <summary>
        /// Constructor para el tablero, se inicializa en 101
        /// despues dependiendo del indice del tablero se sumara o restara un valor
        /// dependiendo si escalera o serpiente
        /// </summary>
        public Tablero()
        {
            _tablero = new int[101];
            for (int i = 1; i < _tablero.Length; i++)
            {
                _tablero[i] = 0;
            }
            //escaleras
            _tablero[5] = 10; // pos 15
            _tablero[22] = 18; // pos 30
            _tablero[41] = 8; // pos 49
            _tablero[60] = 18; // pos 78
            _tablero[65] = 5; // pos 70
            _tablero[77] = 2; // pos 79
            _tablero[80] = 10; // pos 90
            _tablero[94] = 3; // pos 97
            //serpientes
            _tablero[10] = -9; // pos 1
            _tablero[18] = -7; // pos 11
            _tablero[29] = -1; // pos 28
            _tablero[36] = -34; // pos 2
            _tablero[50] = -2; // pos 42
            _tablero[58] = -21; // pos 37
            _tablero[88] = -81; // pos 7
            _tablero[98] = -97; // pos 2
        }
    }
}
