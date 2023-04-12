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
        //Sfrutto il concetto di Overload per Riutilizzare il nome della classe per eseguire la stessa operazione, ma con tipo differente
        public static int SommaNumeri(int n1, int n2)
        {
           return n1 + n2;
        }

        public static double SommaNumeri(double n1, double n2)
        {
            return n1 + n2;
        }

        public static int DiffNum(int n1, int n2)
        {
            //Non aggiungo controlli perché potrebbe servirmi un risultato negativo come nelle calcolatrici scientifiche
            return n1 - n2;
        }

        public static double DiffNum(double n1, double n2)
        {
            //Non aggiungo controlli perché potrebbe servirmi un risultato negativo come nelle calcolatrici scientifiche
            return n1 - n2;
        }

        public static int MoltNum(int n1, int n2)
        {
            return n1 * n2;
        }
        public static double MoltNum(double n1, double n2)
        {
            return n1 * n2;
        }

        public static int AssoluteNum(int n1)
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

        public static double AssoluteNum(double n1)
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

        public static int MinNum(int n1, int n2)
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

        public static double MinNum(double n1, double n2)
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
        public static int MaxNum(int n1, int n2)
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
        public static double MaxNum(double n1, double n2)
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
