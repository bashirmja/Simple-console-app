﻿using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		AAA a= ReturnNull();
		Test(a);
		//Console.Write(a.B);

		var myList= new List<long>();

		Console.WriteLine(myList.Count);

	}

    private static AAA ReturnNull()
    {
        return null;
    }

    public static void Test(AAA a)
	{
		if (a== null)
		{
			a= new AAA();
		}
	}

	public static void TestList(List<long> longList)
	{
		longList.Add(25);
	}
}

public class AAA
{
	public AAA(){
		A="a";
		B="b";
	}

    public string A { get; set; }
	public string B { get; set; }
}