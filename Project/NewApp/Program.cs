﻿// See https://aka.ms/new-console-template for more information
public class Program {

    private static void Main(string[] args)
    {

      int a,b;
      System.Console.Write("a = ");
       a = Convert.ToInt32(Console.ReadLine());
      
      System.Console.Write("b = ");
       b = Convert.ToInt32(Console.ReadLine());
       

        System.Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        System.Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
        System.Console.WriteLine("{0} / {1} = {2}",a,b,a/b);
        System.Console.WriteLine("{0} % {1} = {2}",a,b,a%b);
 
}
}

  
 
