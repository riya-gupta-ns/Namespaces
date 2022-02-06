// See https://aka.ms/new-console-template for more information
using System;
using first_namespace;
using first_namespace.second_namespace;

namespace first_namespace
{
        class Class3
        {
            public void func1()
            {
                Console.WriteLine("Inside First Namespace");
            }
        }

    namespace second_namespace
    {
        class Class4
        {
            public void func2()
            {
                Console.WriteLine("Inside Second Namespace");
            }
        }
    }
}
class Test1
{
    static void Main(string[] args)
    {
        Class3 f1=new Class3();
        Class4 s1=new Class4();
        f1.func1();
        s1.func2();
        Console.ReadKey();
    }
}