using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {

        public static int SommaIntNumeri(int n1, int n2)
        {
           return n1 + n2;
        }

        public static double SommaDoubleNumeri(double n1, double n2)
        {
            return n1 + n2;
        }

        public static int DiffIntNum(int n1, int n2)
        {
            //Non aggiungo controlli perché potrebbe servirmi un risultato negativo come nelle calcolatrici scientifiche
            return n1 - n2;
        }

        public static double DiffDoubleNum(double n1, double n2)
        {
            //Non aggiungo controlli perché potrebbe servirmi un risultato negativo come nelle calcolatrici scientifiche
            return n1 - n2;
        }

        public static int MoltIntNum(int n1, int n2)
        {
            return n1 * n2;
        }
        public static double MoltDoubleNum(double n1, double n2)
        {
            return n1 * n2;
        }

        public static int AssoluteIntNum(int n1)
        {
            if (n1 < 0)
            {
                int result = n1 * (-1);
                return result;
            }
            else
            {
                Console.WriteLine(n1);
                return n1;
            }
        }

        public static double AssoluteDoubleNum(double n1)
        {
            if (n1 < 0)
            {
                double result = n1 * (-1);
                return result;
            }
            else
            {
                Console.WriteLine(n1);
                return n1;
            }
        }

        public static int MinIntNum(int n1, int n2)
        {
            if(n1 < n2)
            {
                return n1;
            }
            else if(n1 > n2)
            {
                return n2;
            }
            else
            {
                return n1;
            }
        }

        public static double MinDoubleNum(double n1, double n2)
        {
            if (n1 < n2)
            {
                return n1;
            }
            else if (n1 > n2)
            {
                return n2;
            }
            else
            {
                return n1;
            }
        }
        public static int MaxIntNum(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else if (n1 < n2)
            {
                return n2;
            }
            else
            {
                return n1;
            }
        }
        public static double MaxDoubleNum(double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else if (n1 < n2)
            {
                return n2;
            }
            else
            {
                return n1;
            }
        }

    }
}
