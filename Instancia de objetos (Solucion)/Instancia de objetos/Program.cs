﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instancia_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda miRueda;
            Rueda miRueda2;
            Rueda miRueda3;
            Rueda miRueda4;
            Auto miAuto;
            Auto miAuto2;
            Auto miAuto3;
            Auto miAuto4;

            //eFabricante fabricante;

            //Auto.CanrtidaDeInstancias = 0;

            miRueda = new Rueda();
            miRueda2 = new Rueda(3);
            miRueda3 = new Rueda("no conozco marcas de ruedas");
            miRueda4 = new Rueda(66 , "nuevamente, no conozco marcas");

            miAuto = new Auto();
            miAuto2 = new Auto();
            miAuto3 = new Auto();
            miAuto4 = new Auto();

            //fabricante = (eFabricante)0;

            
        }
    }
}
