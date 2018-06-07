using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        public BaseClass()
        {

        }
        public BaseClass(string par1)
        {

        }

        public BaseClass(string par1, int par2)
        {

        }

        public BaseClass( int par1)
        {
            Console.WriteLine("base Class Const : {0} ", par1);
        }
        public int bas;
        private int base2;
        protected int base3;

        private void SetBase(int par1)
        {
            base2 = par1;

        }

        protected void SetBase3(int par1)
        {
            base3 = par1;
        }
        public void GetBase23()
        {
            Console.WriteLine("Value : {0} : {1}", base2, base3);

        }
    
       
        public void GetInt()
        {
            bas = 10;
            Console.WriteLine("Value From Base : {0}", bas);
        }
        public void GetIntPublic()
        {
            bas = 10;
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {

        }
        public DerivedClass(int par1) : base(10)
        {
            Console.WriteLine("Base Class Constructo0r: : {0}", par1);
        }
        public void Show()
        {
            Console.WriteLine("From Child Class");
        }

        public void GetFromBaseClass()
        {
            // bas = 20;
            base.base3 = 20;
            base.SetBase3(23);
            base.GetBase23();

//
        }

    }
}
