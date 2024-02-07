using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GregOOPGqn
{
    class SolarSystemCalc
    {
        private string strObjectName;
        protected float fltGravityConst;
        protected static int intCount;
        private float fltMass;

        public int Count
        { get { return intCount;} }

        public string ObjectName
        { get { return strObjectName; } }

        public SolarSystemCalc(string objname, float m)
        {
            strObjectName = objname;
            fltMass = m;
            if (strObjectName == "Earth")
            {
                fltGravityConst = 9.80665f;
            }
            else if (strObjectName == "Moon")
            {
                fltGravityConst = 1.62500f;
            }
            else if (strObjectName == "Mars")
            {
                fltGravityConst = 3.72026f;
            }
            else if (strObjectName == "Saturn")
            {
                fltGravityConst = 11.19000f;
            }
            else if (strObjectName == "Pluto")
            {
                fltGravityConst = 0.61000f;
            }

        }

        public float CalcWeight()
        {
            return fltMass * fltGravityConst;
        }
    }

    class MyInfo : SolarSystemCalc
    {
        private string strName;
        public string Name
        {
            get { return strName; }
        }

        public MyInfo(string name, string obje, float mass) : base(obje, mass)
        {
            strName = name;
            intCount++;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your mass (kg): ");
            float mass = float.Parse(Console.ReadLine());
            Console.Write("What solar system body would you like to measure your weight on? ");
            string objec = Console.ReadLine();
            MyInfo objP1 = new MyInfo(name, objec, mass);

            Console.WriteLine("\n{0}, you weigh {1} Newtons on {2}.", objP1.Name, objP1.CalcWeight().ToString(), objP1.ObjectName);
            Console.WriteLine("Now try with another solar system body!");

            Console.Write("\nEnter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your mass (kg): ");
            mass = float.Parse(Console.ReadLine());
            Console.Write("What solar system body would you like to measure your weight on? ");
            objec = Console.ReadLine();
            MyInfo objP2 = new MyInfo(name, objec, mass);

            Console.WriteLine("\n{0}, you weigh {1} Newtons on {2}.", objP2.Name, objP2.CalcWeight().ToString(), objP2.ObjectName);

            Console.WriteLine("Total number of calculations done: {0}", objP1.Count.ToString());

            Console.ReadKey();
        }
    }
}
