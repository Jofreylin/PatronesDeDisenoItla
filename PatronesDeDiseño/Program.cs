using System;

namespace PatronesDeDiseño
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRUEBA: PATRON DE DISEÑO SINGLETON
            Console.WriteLine("\t=======================================================");
            Console.WriteLine("\tSINGLETON");
            Console.WriteLine("\t---------");
            Console.WriteLine("\t" + Singleton.getInstancia().cadena);

            //PRUEBA: PATRON DE DISEÑO FACTORY METHOD
            PatronFactoryMethod.InterCantidadVotos factM = PatronFactoryMethod.CFactory.Creador(1);
            Console.WriteLine();
            Console.WriteLine("\t=======================================================");
            Console.WriteLine("\tFACTORY METHOD");
            Console.WriteLine("\t--------------");
            Console.WriteLine("\t La cantidad de votos es:"+factM.CuantosVotosHay());

            //PRUEBA: PATRON DE DISEÑO STRATEGY
            PatronStrategy.Strategy strt = new PatronStrategy.Strategy();
            Console.WriteLine();
            Console.WriteLine("\t=======================================================");
            Console.WriteLine("\tSTRATEGY");
            Console.WriteLine("\t--------");
            strt.Jugar();
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\tCAMBIANDO ESTRATEGIA...");
            Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            strt.JugarElRPG();
            strt.Jugar();
        }
    }
}
