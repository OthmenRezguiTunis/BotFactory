
﻿//using System;
//public abstract class Foo
//{
//    static Foo()
//    {
//        Console.Write("constructeur FOO ");
//    }
//    public static string Instance;

//    public static void SetInstance(string ins)
//    {
//        Instance = ins;
//    }
//}

//public class Bar : Foo
//{
//    public static string Instanc2;
//    static Bar()
//    {
//        Console.Write("constructeur Bar ");
//        SetInstance("helo word ");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write(Bar.Instanc2 + "Oops ");
//    }
//}

﻿using System;
public abstract class Foo
{
    static Foo()
    {
        Console.Write("constructeur FOO ");
    }
    public static string Instance;

    public static void SetInstance(string ins)
    {
        Instance = ins;
    }
}

public class Bar : Foo
{
    public static string Instanc2;
    static Bar()
    {
        Console.Write("constructeur Bar ");
        SetInstance("helo word ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write(Bar.Instanc2 + "Oops ");
    }
}

