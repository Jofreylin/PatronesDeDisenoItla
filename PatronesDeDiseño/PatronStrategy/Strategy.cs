using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDeDiseño.PatronStrategy
{
    class Strategy
    {
        //Instancia de la interfaz
        private InterGanasDeJugar ganasDeJugar;

        //Valor por defecto (constructor)
        public Strategy()
        {
            ganasDeJugar = new JugarShooter();
        }

        //Implementacion de nuevo codigo
        public void JugarElShooter()
        {
            ganasDeJugar = new JugarShooter();
        }

        //Implementacion de nuevo codigo
        public void JugarElRPG()
        {
            ganasDeJugar = new JugarRPG();
        }

        //Intercambiador de codigo
        public void Jugar()
        {
            ganasDeJugar.Jugar();
        }
    }
}
