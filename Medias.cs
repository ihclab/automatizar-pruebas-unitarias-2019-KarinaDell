using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) { }

 int i,b=0,num=5;
         double suma=0.0;
           Console.WriteLine("Para salir ingresa cero");
          while(num!=0){
               Console.WriteLine("Ingresa un numero");
               num = Convert.ToInt16(Console.ReadLine());
              suma=suma+num;
              b++;
          }
         Console.WriteLine(suma/(b-1));
        Console.ReadLine();
        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) { }


        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) { }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) { }
    }
}