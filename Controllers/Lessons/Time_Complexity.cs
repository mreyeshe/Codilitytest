using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacion.Controllers.Lessons
{
    public class Time_Complexity
    {
        public int FrogJmp(int X, int Y, int D)
        {
            if(X>=0 && Y>0 && D>0 && X<Y)
            {
                int jumpFixed=0;
                int jumpCount=1;
                jumpFixed=X+D;
                
                int FixedY=Y-jumpFixed;
                int numberContained = (FixedY/D);
                 int reminder = FixedY % D ;

                 jumpCount+=numberContained;

                 if(reminder>0)
                 {
                     jumpCount+=1;
                 }                
                return jumpCount;
            }

            return 0;
        }
        public int PermMissingElem(int [] A)
        {
            if(A.Count()>0)
            {
                 Array.Sort(A);
                int counter=0;
                
                 foreach (var itemArray in A)
                 {
                     counter++;

                     if(itemArray!=counter)
                     {
                         break;
                     }
                 }
                 return counter;
            }
            
            return  0;
        }

        public int TapeEquilibrium(int [] A)
        {
            if(A.Count()>0)
            {
                int P=1;
                int N=A.Length-1;
                int sumRight=0;
                int sumLeft=0;

                for(int i=P;i<=N;i++)
                {
                    sumRight+=A[i];
                }
                
                sumLeft=A[0];
                
                int diff=Math.Abs(sumLeft-sumRight);

                for (;P < N; P++)
                {
                    sumLeft+=A[P];
                    sumRight-=A[P];

                    int newDiff=Math.Abs(sumLeft-sumRight);
                    if(newDiff<diff)
                    {
                        diff=newDiff;
                    }                    
                }

                return diff;
            }

            return 0;
        }

          private void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }
        public int PermMissingElemRespaldo(int [] A)
        {

            if(A.Count()>0)
            {
                 int faltante=0;
                int tope=A.Max();
                int inicio=1;
                bool found=false;
                int mitad=(A.Count()/2);
                int counterReverse=(A.Length-1);
                if((A.Length % 2)!=0)
                {
                    counterReverse=A.Length;
                }

                for (int i = inicio; i < tope; i++)            
                {
                    int counterReverseTemp=counterReverse;

                    for (int j = 0; j <= mitad; j++)
                    {
                        if(A[j]==i ||A[counterReverseTemp]==i)
                        {
                            found=true;
                            break;
                        }

                        counterReverseTemp--;
                    }

                    if(!found)
                    {
                        faltante=i;
                        break;
                    }

                    found=false;
                }

            return faltante;

            }

            return 0;
        }
    }
}