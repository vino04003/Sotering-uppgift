﻿using System;
using System.Diagnostics;
using System.Threading;
namespace bubble
{
    class Program
    {
      static void Main(string[] args) {
      
      Stopwatch stop = Stopwatch.StartNew();
      stop.Start(); 
	
		Random rnd = new Random();
	   int[] arr = new int[5000];
      for (int j = 0; j < 5000; j++)
		   {
			   arr[j]=(rnd.Next(1, 5000)); 
		   }
	
         
         
         int nummer;
            for (int j = 0; j <= arr.Length - 2; j++) {
               for (int i = 0; i <= arr.Length - 2; i++) {
                  if (arr[i] > arr[i + 1]) {
                     nummer= arr[i + 1];
                     arr[i + 1] = arr[i];
                     arr[i] = nummer;
                  }
               }
            }
         stop.Stop();
         
         Console.WriteLine("Sorted:");
         foreach (int p in arr)
         Console.Write(p + " ");
         Console.WriteLine(" ");  
         Console.WriteLine("Time = " + stop.ElapsedMilliseconds + " ms");
         Console.Read();
      }
   }
}

/*
using System;
using System.Diagnostics; 
public class Example {
   static void Main(string[] args) {

    Stopwatch stop = Stopwatch.StartNew();
      stop.Start(); 

      Random num = new Random();
	   int[] arr = new int[13000];
      for (int j = 0; j < 13000; j++)
		   {
			   arr[j]=(num.Next(1, 13000)); 
		   }
	
      int n = 13000;
      
      for (int i = 0; i < n; i++) {
         Console.Write(arr[i] + " ");
      }
      int temp, smallest;
      for (int i = 0; i < n - 1; i++) {
         smallest = i;
         for (int j = i + 1; j < n; j++) {
            if (arr[j] < arr[smallest]) {
               smallest = j;
            }
         }
         temp = arr[smallest];
         arr[smallest] = arr[i];
         arr[i] = temp;
      }
        stop.Stop();

      Console.WriteLine();
      for (int i = 0; i < n; i++) {
         Console.Write(arr[i] + " ");
         Console.WriteLine(" ");
      }
      Console.WriteLine("Time = " + stop.ElapsedMilliseconds + " ms");
   }
}
/*