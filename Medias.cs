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
        public static double mediaAritmetica(params int[] vals) { 

         int i,b=0,num=5;
         double suma=0.0
          while(num!=0){
               Console.WriteLine("Ingresa un numero");
               num = Convert.ToInt16(Console.ReadLine());
              suma=suma+num;
              b++;
          }
        for (i=1; i>=0; i++) {
         Console.WriteLine('000' + i + ':media aritmética: ' suma/(b-1));
        Console.ReadLine();
          }
        }
        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) {


         }
        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) {
            Console.WriteLine("Ingresa un numero");
            num = Convert.ToInt16(Console.ReadLine());
         }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) { 
            //Poner excepción
             Console.WriteLine("Este método no está implementado");
        }
    }
}