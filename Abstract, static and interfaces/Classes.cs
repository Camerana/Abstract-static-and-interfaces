using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__static_and_interfaces
{
    /* 
     * le interfacce non ammettono modificatori di visibilità: public, private etc..
     * perché al loro interno tutto è public di default
     * le interfacce non ammettono le parole chiave static e virtual
     * possono avere delle properties, ma non dei fields
     */
    public interface IClass
    {
        string nome { get; set; }
        string cognome;
        public static void staticfunc();
        public void func();
        virtual void func();
    }
    /*
     * una classe può implementare una o più interfacce...
     */
    public class Class0 : IClass
    {
        public string nome { get; set; }
        public static void staticfunc() { }
        public void func() { }
    }
    /*
     * ...e ne deve possedere tutti i membri
     */
    public class Class1 : IClass
    {
        //public string nome { get; set; }
        public static void staticfunc() { }
        public void func() { }
    }
    /*
     * una classe astratta può ereditare da altre classi (non statiche)
     * e implementare interfacce*/
    public abstract class Class2 : Class1, IClass
    {
        public string nome { get; set; }

        /*
         * da un contesto statico (in questo caso dall'interno di staticfunc) 
         * non si può richiamare base, visto che non c'è l'instanza corrente,
         * ma ci si può accedere tramite il nome della classe (come da norma).
         * una funzione statica inoltre non può essere virtual
         */
        public static virtual void staticfunc()
        {
            base.staticfunc();
            Class1.staticfunc();
        }
        /*
         * l'unico modificatore possibile di un membro ereditato
         * da un'interfaccia è public
         */
        //private void func() { }
        //protected void func() { }
        public virtual void func()
        {
            //base.staticfunc();
            base.func();
        }
    }
    /*
     * una classe statica non può ereditare da classi
     * e non può implementare interfacce*/
    public static class Class3 : Class1, IClass
    {
        /*
         * le funzioni possono avere i soliti modificatori,
         * ma non fields non statici e funzioni non statiche
         */
        public static string cognome;
        public string nome;

        //private static void staticfunc() { }
        //protected static void staticfunc() { }
        public static void staticfunc() { }

        //private void func() { }
        //protected void func() { }
        public void func() { }
    }

    /*
     * una classe può ereditare da una classe e implementare una o più interfacce
     */
    public class Class4 : Class1, IClass
    {
        public static void staticfunc() { }
        public void func() { }
    }

    /*
     * una classe può ereditare da una classe astratta e implementare una o più interfacce
     */
    public class Class5 : Class2, IClass
    {
        public static override void staticfunc()
        {
            base.staticfunc();
        }
        public override void func()
        {
            base.func();
        }
    }

    /*
     * una classe non può ereditare da una classe statica
     */
    public class Class6 : Class3
    {
    }

    /*
     * una classe statica non può ereditare da una classe statica
     */
    public static class Class7 : Class3
    {
    }
}
