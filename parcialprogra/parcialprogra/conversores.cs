using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcialprogra
{

    class conversores

    {
        //MONEDAS
        public string[][] conversor = {
            new string [] {"Dolares", "Colones (SV)", "Yenes", "Rupia", "Peso (Chileno)", "Peso (MX)",
          "Peso (Argentino)", "Bitcoin "  },
            //UNIDADES DE ALMACENAMIENTO
            new string[] { "Megabyte", "bit ", "byte " , "Kilobyte ", "Gigabyte  ", "Terabyte  " },

        };
        public double[][] valores = {
            //VALORES DE LAS MONEDAS
    new double []{1,8.75,111.27,69.75,667.08,19.36,39.69,0.00026 },
    //VALORES DE ALAMACENAMIENTO
    new double []{1, 8388608, 1048576, 1024, 0.0009765625, 0.00000095367431660625},
     };
        public double convertir(int opcion, int de, int a,double cantidad)
            {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
    }
}
}
