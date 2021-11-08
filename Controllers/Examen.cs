using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplicacion.Controllers
{
    public class Examen
    {
        public int Solution(int [] A, int[] B, int M, int X, int Y)
        {
            //A = WightAndnumberOfPeoples,
            //B = numberOfFloorsStopsPerPeople,
            //M = MaxOfFloors,
            //Y = WeightElevatorLimit,
            //X = ElevatorpeopleCapacity,

            /*Validacion*/
            if(M>0 && X>0 && Y>0 && (A.Max()<=Y) && (B.Max()<=M) && A.Length==B.Length)
            {
                int countPersons=0;
                int sumWeight=0;
                int stops=0;
                int BgExtra=1;
                
                List<int> floorsPeople= new List<int>();

                for (int i = 0; i < A.Length; i++)
                {
                    if(sumWeight+A[i]>=Y || countPersons>=X)
                    {
                         /*Liberacion de elevador*/
                        stops+=floorsPeople.Count()+BgExtra;
                        floorsPeople= new List<int>();
                        sumWeight=0;
                        countPersons=0;
                    }

                    sumWeight+=A[i];
                    countPersons=(i+1);
                    if(!floorsPeople.Contains(B[i]))
                    {
                        floorsPeople.Add(B[i]);
                    }
                }

                stops+=floorsPeople.Count()+BgExtra;

                return  stops;
            }
            return -1;
        }

        public int CalculateElevatorStops(int [] A, int[] B, int M, int X, int Y)
        {




            return 0;
        }

        public int Solucion1(int A , int B)
        {
            char[] cadena=B.ToString().ToCharArray();
            char[] cadenaMatch=A.ToString().ToCharArray();
            int position=-1;
            if(A>0 && B>0)
            {
                for (int i = 0; i < cadena.Length-1; i++)
                {
                    if(cadena[i]==cadenaMatch[0])
                    {
                        position=(i);
                        int counter=0;
                        foreach (var item in cadenaMatch)
                        {
                            if((i+counter)<=cadena.Length-1)
                            {
                                if(cadena[i+counter]!=item)
                                {
                                    position=-1;
                                }
                            }
                            else
                            {
                                position=-1;
                            }
                            counter++;
                        }

                        if(position>0)
                        {
                            break;

                        }
                    }
                }

                return position;
            }
            
            return -1;
        }

          public int Test(int [] A)
        {
            int smallest=0;
              Array.Sort(A);
            
            if((A.Distinct().Count())==A.Max())
            {
                smallest=A.Max()+1;
                return smallest;
            }
            else if(A.Any(d=>d<0))
            {
                smallest=1;

                if(A.Any(d=>d>0))
                {
                    foreach (var itemArray in A)
                    {
                        if(itemArray>0)
                        {
                            smallest++;
                            if(itemArray!=smallest)
                            {
                                break;
                            }
                        }
                    }
                }

                 return smallest;
            }
            else
            {
                 foreach (var itemArray in A.Distinct())
                 {
                     smallest++;

                     if(itemArray!=smallest)
                     {
                         break;
                     }
                 }
                 return smallest;
            }
        }
    }
}