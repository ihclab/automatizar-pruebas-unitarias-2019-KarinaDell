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
        public static double mediaAritmetica(params object[] vals) { 
         double suma=0;
         double media = 0;
                for (int i = 0; i < vals.Length; i++) {
                    suma = suma + vals[i];
                }
               media = suma / vals.Length;
                return media;
        }
        
        /*
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) {
                return Math.Pow(x,1/n);
         }
        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) {
            double resultado = 1;
            for (int i = 0; i < vals.Length; i++) {
                resultado = resultado * vals[i];
            }
            double mG = raizEnesima(resultado, vals.Length);
            return mG;
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