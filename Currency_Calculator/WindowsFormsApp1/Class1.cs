using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public  static class Rates
   {
        public static double Value3;

      public static double[] myEuro = { 1, 1.10, 1.21 };
        // Index: 1 = Euro, 1.10 = Pound, 1.21 = Dollar

       public static double[] myPound = { 1, 1.10, 1.33 };
        // Index: 1 = Pound, 1.10 = Euro, 1.33 = Dollar

       public static double[] myDollar = { 1, 0.82, 0.75 };
        // Index: 1 = Dollar, 0.82 = Euro, 0.75 = Pound 
   }
}
