using System;
using System.Collections.Generic;
using System.Runtime;
using System.Linq;
using aplicacion.Controllers.Lessons;
using aplicacion.Controllers;

namespace aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class_binary_Iterations solution= new Class_binary_Iterations();
            // Console.WriteLine(solution.solution(1041));
            // Arrays solution= new Arrays();
            // Console.WriteLine("Resultado:");
            // var result=solution.SolutionArray(new int[] {},3);
            // Arrays solution= new Arrays();
            // Console.WriteLine("Resultado:");
            // var result=solution.OddOccurrencesInArray(new int[] {3,3,4,4,5,5,6,6,6});
            //     Console.WriteLine(result);
            // Time_Complexity solution= new Time_Complexity();
            // var result=solution.FrogJmp(10,70,30);
            // Time_Complexity solution= new Time_Complexity();
            // var result=solution.PermMissingElem(new int[] {2});
            // Console.WriteLine(result);
            //  Time_Complexity solution= new Time_Complexity();
            // var result=solution.TapeEquilibrium(new int[] {3,1,2,4,3});
            // Console.WriteLine(result);
            Examen solucion = new Examen();

            //  var result  =solucion.Test(new int[] {1, 3, 6, 4, 1, 2});  
            // var result  =solucion.Test(new int[] {1, 2, 3});  
            // int number1=-1;
            // int number2=-3;
            // var result =solucion.Test(new int[] {number1,number2 });  
            // var result1=solucion.Solucion(53,1953786);
            // var result2=solucion.Solucion(78,195378678);
            // var result=solucion.Solucion(57,153786);
            // Console.WriteLine(result);

            int[]A = new int[] {40,40,100,80,20};
            int[]B = new int[] {3,3,2,2,3};
             var result=solucion.Solution(A,B,3,5,200);
            //  Console.WriteLine(result);

            // var result1=solucion.Solucion2(53,1953786);
            // var result2=solucion.Solucion2(78,195378678);
            // var result=solucion.Solucion2(57,153786);
            Console.WriteLine(result);
      
            
            Console.WriteLine("\npress any key to exit the process...");
            Console.Read();
        }
    }
    
}
