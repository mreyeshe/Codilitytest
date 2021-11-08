using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacion.Controllers.Lessons
{
    public class Class_binary_Iterations
    {
    public int solution(int N)
    {
        if(N>0)
        {
            int initZero=0;
            int endZero=0;
            int lengthValue=0;    
            string Sbinary=Convert.ToString(N,2);
             char[] charArr = Sbinary.ToCharArray();
             int counter=1;
             List<int> distancias= new List<int>();

             foreach (var charItem in charArr)
             {
                 
                 if(charItem=='0'&& counter>1)
                 {
                     if(initZero>0)
                     {
                         endZero=counter;    
                     }
                     else
                     {
                        initZero=counter;
                        endZero=counter;     
                     }
                    
                 }
                 else if(charItem=='1' && counter>1)
                 {
                     if(initZero>1 && endZero>1)
                     {
                        int longitud=(endZero+1)-initZero;
                        if(longitud>0)
                        {
                            distancias.Add(longitud);
                        }
                        initZero=0;
                        endZero=0;
                     }
                 }
                 counter+=1;                 
             }
             if(distancias.Count()>0)
             {
                 lengthValue=distancias.Max();
             }
                //  Console.WriteLine("logitud:"+lengthValue);
                return lengthValue; 
        }
        return 0; 
    }
    }
}