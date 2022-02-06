// See https://aka.ms/new-console-template for more information
using System;
using first_namespace;
using second_namespace;

namespace first_namespace
{
    /// <summary>
    /// Class 1
    /// </summary>
    class Class1
    {
        /// <summary>
        /// function of class1 and namespace 1
        /// </summary>
        public void func1()
        {
            Console.WriteLine("Inside First Namespace");
        }
    }
}
namespace second_namespace
{
    /// <summary>
    /// Class 2
    /// </summary>
    class Class2
    {
        /// <summary>
        /// function of class2 and namespace 2
        /// </summary>
        public void func2()
        {
            Console.WriteLine("Inside Second Namespace");
        }
    }
}
/// <summary>
/// Main Class
/// </summary>
class Test
{
    static void Main(string[] args)
    {
        /// <summary>
        /// simple usage of namespaces
        /// </summary>
        /// <returns></returns>
        /* first_namespace.Class1 f1=new first_namespace.Class1();
        second_namespace.Class2 s1=new second_namespace.Class2();
        f1.func1();
        s1.func2();
        Console.ReadKey(); */



        Class1 f1=new Class1();
        Class2 s1=new Class2();
        f1.func1();
        s1.func2();
        Console.ReadKey();
    }
}