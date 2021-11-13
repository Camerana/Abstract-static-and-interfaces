using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__static_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //un'interfaccia non è istanziabile
            IClass ic = new IClass();
            ic.func();

            Class0 c0 = new Class0();
            c0.nome = "c0";
            c0.func();
            c0.staticfunc();
            Class0.staticfunc();

            Class0 c01 = new Class0();
            c01.nome = "c01";

            Class1 c1 = new Class1();
            c1.func();
            c1.staticfunc();
            Class1.staticfunc();

            //una classe astratta non è istanziabile
            Class2 c2 = new Class2();
            c2.func();
            c2.staticfunc();
            Class2.staticfunc();

            //una classe statica non è istanziabile
            Class3 c3 = new Class3();
            c3.func();
            c3.staticfunc();
            Class3.staticfunc();

            Class4 c4 = new Class4();
            c4.func();
            c4.staticfunc();
            Class4.staticfunc();

            Class5 c5 = new Class5();
            c5.func();
            c5.staticfunc();
            Class5.staticfunc();

            Class6 c6 = new Class6();
            c6.func();
            c6.staticfunc();
            Class6.staticfunc();

            Class7 c7 = new Class7();
            c7.func();
            c7.staticfunc();
            Class7.staticfunc();
        }
    }
}
