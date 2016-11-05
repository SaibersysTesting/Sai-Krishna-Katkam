using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Bike
    {
        public int mileage = 65;
        public string color = "Black";
        private string formula = "a*b";
        //Its public – so accessible outside class
        public int GetMileage()
        {
            return mileage;
        }

        //Its public – so accessible outside class
        public string GetColor()
        {
            return color;
        }
        //Its private – so not accessible outside class
        private string GetEngineMakeFormula()
        {
            return formula;
        }

        //Its public – so accessible outside class
        public string DisplayMakeFormula()
        {
            //"GetEngineMakeFormula()" is private but accessible and limited to this class only
            return GetEngineMakeFormula();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Bike objBike = new Bike();
            Console.WriteLine("Bike mileage is : " + objBike.GetMileage()); //accessible outside "Bike"
            Console.WriteLine("Bike color is : " + objBike.GetColor()); //accessible outside "Bike"
                                                                        //we can't call this method as it is inaccessible outside "Bike"
                                                                        //objBike.GetEngineMakeFormula(); //commented because we can't access it
            Console.WriteLine("Bike color is : " + objBike.DisplayMakeFormula()); //accessible outside
            Console.Read();
        }
    }
}
