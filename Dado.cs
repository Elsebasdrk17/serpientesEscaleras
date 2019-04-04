using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesyEscaleras
{
    class Dado
    {
        public static Random _rdn = new Random();
        /// <summary>
        /// Funcion para crear un numero aleatorio
        /// </summary>
        /// <returns>Un numero aleatorio del 1 al 6</returns>
        public int lanzar()
        {
            return _rdn.Next(1, 7);
        }
    }
}
