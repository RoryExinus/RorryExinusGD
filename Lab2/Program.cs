using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class RightTriangle

    {
        protected double fSide;
        protected double sSide;
        protected double tSide;
        protected double fAngle;
        public RightTriangle(double fSide, double sSide)
        {
            this.FSide = fSide;
            this.SSide = sSide;
        }    
        public RightTriangle()
        {

        }
        public double FSide
        {
            get { return fSide; }
            set { fSide = Math.Abs(value); } 
        }
        public double SSide
        { 
            get => sSide; set => sSide = Math.Abs(value); 
        }
        public virtual double GetPerimeter()
        {
            tSide = Math.Sqrt(Math.Pow(fSide, 2) + Math.Pow(sSide, 2));
            double perimeter = fSide + sSide + tSide;
            return perimeter;
        }
        public virtual void  ShowOtherValue()
        {
            fAngle = 90;
            double temp = (Math.Pow(fSide,2) + Math.Pow(tSide, 2) -  Math.Pow(sSide, 2)) / (2 * fSide * tSide);
            double sAngle = Math.Cos(temp) * 180 / Math.PI;
            double tAngle = 180 - (fAngle + sAngle);
            Console.WriteLine("First side = {0}, Second Side = {1}, Third Side = {2}\n First angle = {3}, Second angle = {4}, Third angle = {5}\n",fSide,sSide,tSide,fAngle,sAngle,tAngle);
        }
    }
    public class Triangle : RightTriangle
    {
        public double FAngle { get => fAngle; set => fAngle = Math.Abs(value); }
        public Triangle(double fSide, double sSide, double fAngle) : base(fSide, sSide)
        {
            this.FAngle = fAngle;
        }
        public Triangle() 
        {
        
        }

        public override double GetPerimeter() 
        {
            tSide = Math.Sqrt(Math.Pow(fSide, 2) + Math.Pow(sSide, 2) - 2 * fSide * sSide * Math.Cos(fAngle));
            double perimeter = fSide + sSide + tSide;
            return perimeter;
        }
        public override void ShowOtherValue()
        {
            double temp = (Math.Pow(fSide, 2) + Math.Pow(tSide, 2) - Math.Pow(sSide, 2)) / (2 * fSide * tSide);
            double sAngle = Math.Cos(temp) * 180 / Math.PI;
            double tAngle = 180 - (fAngle + sAngle);
            Console.WriteLine("First side = {0}, Second Side = {1}, Third Side = {2}\n First angle = {3}, Second angle = {4}, Third angle = {5}\n", fSide, sSide, tSide, fAngle, sAngle, tAngle);
        }
        static void Main()
        {
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.FSide = 3;
            rightTriangle.SSide = 4;
            Console.WriteLine("Perimetr = " + rightTriangle.GetPerimeter());
            rightTriangle.ShowOtherValue();
            Triangle triangle = new Triangle();
            triangle.FSide = 7;
            triangle.SSide = 8;
            triangle.FAngle = 45;
            Console.WriteLine("Perimetr = " + triangle.GetPerimeter());
            triangle.ShowOtherValue();

        }
    }
}


