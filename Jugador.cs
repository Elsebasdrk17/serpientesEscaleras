using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    //abstract class Jugador:Tablero no supe como hacerla abstracta
    class Jugador:Tablero
    {
        private int _numeroJ;
        private int _pos;
        /// <summary>
        /// Constructor para los jugadores
        /// </summary>
        /// <param name="numero">Obtiene el numero de jugador al momento de ser inicializado</param>
        public Jugador(int numero){
            _pos = 0;
            _numeroJ = numero;
        }
        public int pos
        {
            get { return _pos; }
        }
        public int numeroJ
        {
            get { return _numeroJ; }
        }
        /// <summary>
        /// Funcion que permite al jugador avanzar en el tablero de acuerdo al dado lanzado
        /// </summary>
        /// <param name="rnd">Numero aleatorio del 1 al 6 representando al dado</param>
        public void avanzar(int rnd)
        {
            _pos += rnd;
            /*
             puede llegar un momento en donde la posicion sea mayor al indice permitido del tablero
             es por eso que se compara, si es mayor a 100, la posicion sera igualada a 100 y si no,
             se sumara al valor que este en esa posicion del tablero
             */
            if (_pos > 100)
            {
                _pos = 100;
            }
            else
            {
                _pos += _tablero[_pos];
            }
        }
        public override string ToString()
        {

            return "Jugador: " + _numeroJ.ToString() + " esta en: " + _pos.ToString() + Environment.NewLine;
        }
    }
}
