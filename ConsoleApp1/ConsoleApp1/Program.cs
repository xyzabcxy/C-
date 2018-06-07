using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triange
    {
        public int bas;
        public int height;
        public static int staticint;
        public static void SetStaticValue(int par1)
        {
            staticint = par1;
        }

        public void SetValue(int par1)
        {
            staticint = par1;
        }
        public void GetStatic()
        {
            SetStaticValue(56);
            Console.WriteLine("Static Value {0}", staticint);
        }

        public Triange(int a, int b)
        {
            Console.WriteLine("Consttructor Called");
            bas = a;
            height = b;

        }
        public void GetArea()
        {
            double area = (0.5 * (bas * height));
            Console.WriteLine("Area is: {0}", area);
        }

        public double GetArea(int par1, int par2)
        {
            return (0.5 * (par1 * par2));

        }

        public double GetArea(double par1, double par2)
        {
            return (0.5 * (par1 * par2));

        }


        public double GetTrianArea()
        {
            double area = (0.5 * (bas * height));
            return area;
        }
        public void SetValue(int par1, int par2) {
            bas = par1;
            height = par2;

        }

    }

    public abstract class AbstClass
    {
        private int a;
        private int b;
        protected int add = 0;

        public abstract void Add(int par1, int par2);

        public abstract void Add(double par1, double par2);

        public void Display()
        {
            Console.WriteLine("Addition is: {0}", add);

        }
    }

    public abstract class ChildClass : AbstClass
    {


        public override void Add(int par1, int par2)
        {
            base.add = (par1 + par2);
        }


    }

    public class GrandChild: ChildClass{

        public override void Add(double par1, double par2)
        {
            base.add = (int) (par1 + par2);

        }

    }
    public class BaseClaseOne : AbstClass
    {
        public override void Add(int par1, int par2)
        {
            base.add = (par1 + 20 + 230 + par2);
        }
        public override void Add(double par1, double par2)
        {
            base.add = (int)(par1 + 20 + 230 + par2);
        }


    }
   

    class Program
    {
        static void Main(string[] args)
        {
            GrandChild obj = new GrandChild();
            obj.Add(23, 45);

            obj.Display();
            obj.Add(23.23, 45);
            obj.Display();
            BaseClaseOne obj2 = new BaseClaseOne();
            obj2.Add(12, 13);
            obj2.Display();
            obj2.Add(12.23, 13);
            obj2.Display();


            // AbstClass obj = new AbstClass();
            //Triange obj = new Triange(10, 20);
            //Triange obj1 = new Triange(10, 20);
            //obj1.GetArea();
            //Console.WriteLine("Area : {0}", obj1.GetArea(10,20));
            //Console.WriteLine("Area : {0}", obj1.GetArea(10.0, 20.9));
            ////obj1.SetValue(123);
            ////obj1.GetStatic();
            ////obj1.SetValue(123);
            ////Triange.staticint = 10;
            //obj1.GetStatic();

            //DerivedClass der = new DerivedClass(10);
            //der.GetFromBaseClass();

            //der.GetIntPublic();
            //der.Show();
            //der.GetFromBaseClass();
            //der.


            //obj1.height = 10;
            //obj1.bas = 20;

            //obj.height = 100;
            //obj.bas = 200;

            //obj.GetArea();
            //obj1.GetArea();
            //obj.SetValue(1000, 200);
            //string var1 = @"C:\Users\MELGAREJO\Documents\visual studio 2015\Projects\ConsoleApp1";
            //int var2 = 10;
            //bool var3 = true;
            //char var4 = 'A';
            //Console.WriteLine(var1);
            //Console.WriteLine("Values {1}, {0}, {2}, {3}", var1, var2, var3 , var4 );
            //Console.ReadKey();
            //char input = (char)Console.Read();
            //for (int i=0; i<10;i = i+1)
            //{
            //    Console.WriteLine("The input is: {0}", i);

            ////}
            //int i = 0;
            //while (i < 10) {
            //    Console.WriteLine("The input is : {0}", i);
            //    i = i + 1;
            //}


            //switch (input)
            //{
            //    case 'a':
            //        Console.WriteLine("The input is:", input);
            //        break;
            //    case 'b':
            //        Console.WriteLine("The input is:", input);
            //        break;
            //    case 'c':
            //        Console.WriteLine("The input is:", input);
            //        break;
            //    default:
            //        Console.WriteLine("The input is:", input);
            //        break;

            //}

            //if ((input == 'a') || (input == 'b') || (input == 'c'))
            //{
            //    Console.WriteLine("the input is : {0}", input);
            //}
            //else
            //{
            //    Console.WriteLine("the input is Not Valid: {0}", input);
            //}

            Console.ReadKey();

        }
    }
}
