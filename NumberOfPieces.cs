using System;
namespace maximumsteps
{ 
public class NumberOfPieces
{
    int[] array = new int[1000];
    
    public int GetInputValues(int numberofinput)
    {

     int number;
     //loop for storing value in an array list
     for ( number = 0 ;number < numberofinput ;number ++)
     { 
        Console.Write("");
        array[number] = Convert.ToInt32(Console.ReadLine());
     }
     
          //calculating the maximum number pieces of land position
          for( number = 1 ;number <= numberofinput ;number ++)
          {
            if(number != -1)
            {
            array[number] = number*(number-1)/2 + 
                 number*(number-1)*(number-2)*(number-3)/24 + 1 ;
                        
            Console.WriteLine("For " + number + " arbitrary point, maximum number pieces of land possible is  " +array[number]); 
            }

          }
          return array[number];
    
    }
    
//main method
public static void Main(string[] args)
{

        NumberOfPieces steps = new NumberOfPieces();
        int Iteration, IterationIndex;
        Iteration = -1;
        
        while(Iteration < 1)
        {

        Console.Write("\nEnter the Number of Testcases :");

        Iteration = Convert.ToInt32(Console.ReadLine());

        if(Iteration < 1)
         {
            Console.WriteLine("Enter an valid number : ");
         }
         
         for(IterationIndex = 1 ;IterationIndex <= Iteration ;IterationIndex ++)
        {

         Console.Write("\nEnter the input : ");
         int numberofinput = Convert.ToInt32(Console.ReadLine()); 
         steps.GetInputValues(numberofinput);
       
        }   
        }        
            
}
}
}