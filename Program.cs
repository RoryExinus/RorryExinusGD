
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class GeometryProgression
    {
        protected double a0;
        protected int n;
        protected double q;
        public GeometryProgression(double a0, int n, double q) 
        {
            this.a0 = a0;
            this.n = n;
            this.q = q;
        }
        public void InputValue(double a0S, int nS, double qS)
        {
            a0 = a0S;
            n = nS;
            q = qS;
        }
        public double GetGeomProgres()
        {
            double lastElem = a0 * Math.Pow(q, n - 1);
            return lastElem;
        }
    }
    class Program
    {
        static void Main()
        {
            GeometryProgression[] lastEmlem = new GeometryProgression[100];
            double a0 = 0;
            int n = 0;
            double q = 0;
            double a0S = 0;
            int nS = 0;
            double qS = 0;
            int count;
            int index = 0;
            float result;
            int intresult;
            string check;
            bool res;
            Console.WriteLine("Please, input Geometry Progression count: ");
            do
            {
                check = Console.ReadLine();
                res = Int32.TryParse(check, out intresult);
                if (!res)
                {
                    Console.WriteLine("Error, can`t parse string in int");
                }
            } while (!res);
            count = intresult;
            for (int i = 0; i < count; i++)
            {
                lastEmlem[i] = new GeometryProgression(a0, n, q);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Input value for Geometry Progression#" + (i + 1));
                Console.WriteLine("input a0: ");
                do
                {
                    check = Console.ReadLine();
                    res = float.TryParse(check, out result);
                    if (!res)
                    {
                        Console.WriteLine("Error, can`t parse string in float");
                    }
                } while(!res);
                a0S = result;
                Console.WriteLine("input n: ");
                do
                {
                    check = Console.ReadLine();
                    res = Int32.TryParse(check, out intresult);
                    if (!res)
                    {
                        Console.WriteLine("Error, can`t parse string in int");
                    }
                } while (!res);
                nS = intresult;
                Console.WriteLine("input q: ");
                do
                {
                    check = Console.ReadLine();
                    res = float.TryParse(check, out result);
                    if (!res)
                    {
                        Console.WriteLine("Error, can`t parse string in float");
                    }
                } while (!res);
                qS = result;
                lastEmlem[i].InputValue(a0S, nS, qS);
            }
            double max = lastEmlem[0].GetGeomProgres();
            Console.Clear();
            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("Geometry progression#" + (i + 1) +  " = " + lastEmlem[i].GetGeomProgres());
                if (max < lastEmlem[i].GetGeomProgres())
                {
                    max = lastEmlem[i].GetGeomProgres();
                    index = i;
                }
            }
            Console.WriteLine("Geometry progression with  higher last elem -  " + (index + 1));
        }
    }
}
