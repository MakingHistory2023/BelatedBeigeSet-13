using System;

public class Perfect {
  public static void Main (string[] args) 
  {
    int n,i,sum;
    for(n=1;n<=1000;n++)
    {
      i=1;
      sum = 0;
      while(i<n)
        {
          if(n%i==0)
          sum=sum+i;
          i++;
          }
      if(sum==n)
      Console.WriteLine("{0}",n);
      }
    Console.WriteLine("\n");
    }
  }