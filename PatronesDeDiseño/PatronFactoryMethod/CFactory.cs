using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño.PatronFactoryMethod
{
    class CFactory
    {
        //Valores que no cambiaran 
        private const int partidoVerde = 1;
        private const int partidoRojo = 2;

        //Creacion del metodo creador de objetos
        public static InterCantidadVotos Creador(int tipo)
        {
            //Creacion de las intancias
            if (partidoVerde.Equals(tipo))
            {
                return new PartidoVerde();
            }
            else if(partidoRojo.Equals(tipo))
            {
                return new PartidoRojo();
            }
            else
            {
                return null;
            }
        }
    }
}
