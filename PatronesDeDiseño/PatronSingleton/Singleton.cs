using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño
{
    class Singleton
    {
        //Instanciar la clase
        private static Singleton instancia;

        //Crear el atributo global
        public string cadena = "Cadena de conexion a la base de datos";
        private Singleton()
        {
            
        }

        //Metodo que devuelve el unico atributo de la clase
        public static Singleton getInstancia()
        {
            //Si la instancia no ha sido creada, la creara
            if(instancia == null)
            {
                instancia = new Singleton();
            }

            return instancia;
        }

        
    }
}
