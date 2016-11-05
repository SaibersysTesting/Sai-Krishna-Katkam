using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Bike
    {
        public int mileage = 65;
        public string color = "Black";
        private string formula = "a*b";
      
        public int GetMileage()
        {
            return mileage;
        }

        
        public string GetColor()
        {
            return color;
        }

        
        private string GetEngineMakeFormula()
        {
            return formula;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Bike objBike = new Bike();
            Console.WriteLine("Bike mileage is : " + objBike.GetMileage());
            Console.WriteLine("Bike color is : " + objBike.GetColor()); 
                                                                        
                                                                       
            Console.Read();
        }
    }
}
