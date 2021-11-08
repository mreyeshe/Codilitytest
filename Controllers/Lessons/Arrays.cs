using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacion.Controllers.Lessons
{
    public class Arrays
    {

        public int[] SolutionArray(int[] A, int K)
        {
            if(A.Count()>0)
            {
                    int SizeArray=(A.Count()-1);

                int[] newArray= new int[A.Count()];

                if(K>0)
                {
                    newArray[0]=A[SizeArray];
                    int counter=1;

                    foreach (var itemArray in A)
                    {
                        if(counter<=SizeArray)
                        {
                            newArray[counter]=itemArray;
                        }
                        counter++;
                    } 

                    K--;

                    return SolutionArray(newArray,K);
                }
                return A;

            }
            return A;
        } 

          public int OddOccurrencesInArray(int[] A)
        {
             if(A.Count()>0)
            {
                List<KeyValuePair<int,int>> coincidencias= new List<KeyValuePair<int,int>>();
                var result=A.GroupBy(d=>d).Select(s=>new {valor=s.Key,cuenta=s.Count()});
                var impares=result.Where(c=>(c.cuenta % 2)!=0);
                
                return impares.FirstOrDefault().valor;

            }

            return 0;
        }
        
        public int CountOccurrences(int[] A)
        {
             if(A.Count()>0)
            {
                List<KeyValuePair<int,int>> coincidencias= new List<KeyValuePair<int,int>>();
                var result=A.GroupBy(d=>d).Select(s=>s.Key);
                var result2=A.GroupBy(d=>d).Select(s=>s.Count()).Max();
                return 0;

            }

            return 0;
        }
    }
}