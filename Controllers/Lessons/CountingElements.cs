using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacion.Controllers.Lessons
{
    public class CountingElements
    {
        public int FrogRiverOne(int X, int [] A)
        {
            if ((A != null || A.Length != 0) && X>0)
            {
                int[] B= A.Distinct().ToArray();

                if(B.Length==X)
                {
                    int respuesta= Array.IndexOf<int>(A,B[B.Length-1]);

                    return respuesta;
                }
                
                return -1;
            }

            return -1;
        }

        public int PermCheck(int [] A)
        {
            if(A!=null || A.Length!=0)
            {
                int min=A.Min();
                int max=A.Max();
                int[] B= A.Distinct().ToArray();

                if(B.Any(d=>d==1))
                {
                    if(B.Length==A.Length)
                    {
                        if(B.Count()==1)
                        {
                            if(1==B[0])
                            {
                                return 1;
                            }
                            else
                            {
                                return 0;
                            }

                        }
                        else
                        {
                            int distance = Math.Abs(max-min);
                            return (distance==(B.Length-1)?1:0);
                        }
                    }
                }
                return 0;
            }

            return 0;
        }
    
        public int[] MaxCounters(int N, int[] A)
        {
            int counter=0;
            int cond= N+1;
            int maxCounter=0;

            for (int i = 0; i < A.Length; i++)
            {
                
            }    


            return new int[] {};

            
        }

        public string NumerosLetras()
        {
            return "";
        }

        public bool Anagrama(string a, string b)
        {
            char[] arreglo1=a.ToCharArray();
            char[] arreglo2=b.ToCharArray();
            int tope=arreglo2.Length-1;
            bool esAnagrama=true;

            for (int i = 0; i < arreglo1.Length-1; i++)
            {
                if(i<=tope)
                {
                    if(arreglo2[i]!=arreglo1[i])
                    {
                        esAnagrama=false;
                        break;

                    }
                }
            }

            return esAnagrama;
        }

        public int[] Suma(int a , int b)
        {
            
            int sobra =0;
            int[] arreglo1;
            int[] arreglo2;

            if(a <= b)
            {
                // int[] arreglo3 =a.ToString().Select(q =>int.Parse(q.ToString())).ToArray();
                arreglo1 =Array.ConvertAll(a.ToString().ToCharArray(), c=>(int)Char.GetNumericValue(c));
                arreglo2 =Array.ConvertAll(b.ToString().ToCharArray(), c=>(int)Char.GetNumericValue(c));
            }
            else
            {
                arreglo1 =Array.ConvertAll(b.ToString().ToCharArray(), c=>(int)Char.GetNumericValue(c));
                arreglo2 =Array.ConvertAll(a.ToString().ToCharArray(), c=>(int)Char.GetNumericValue(c));
            }

            int finalArreglo2= arreglo2.Length-1;
            List<int> resultado= new List<int>();

            for (int i = (arreglo1.Length-1); i >= 0; i--)
            {

                if(finalArreglo2>=0)
                {
                    int sumaTemporal=arreglo1[i]+arreglo2[finalArreglo2]+sobra;

                    if(sumaTemporal>=10)
                    {
                        int[] ArrayTemporal=Array.ConvertAll(sumaTemporal.ToString().ToCharArray(), c=>(int)Char.GetNumericValue(c));
                        int  DigitoRemanente=ArrayTemporal[0];
                        resultado.Add(ArrayTemporal[0]);
                        sobra=ArrayTemporal[ArrayTemporal.Length-1];
                    }
                    else
                    {
                        resultado.Add(sumaTemporal);
                    }
                }
                  finalArreglo2--;
            }

            if(sobra>0)
            {
                resultado.Add(sobra);
            }
            resultado.Reverse();

            return resultado.ToArray();
        } 

      
    }
}