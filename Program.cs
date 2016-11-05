using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Base
    {
        public virtual string CreatorName()
        {
            return "Sai";
        }
    }
    public class Child : Base
    {
        //same method name with same signature/parameters
        public override string CreatorName()
        {
            return "SaiKrishna Katkam";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Base objBase = new Child();
            Console.WriteLine(objBase.CreatorName());
            Console.Read();
        }
    }
}
