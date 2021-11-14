using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codilitytest.Controllers
{
    public class ExamenCoderByte
    {
        public int CoderByte(int a)
        {
            /*123*/ //- /*132*/           

            /* 1 2 4 5 3 */ //- /* 1 2 5 4 3 */

            /* 12453 */ //- /* 12543 */
            /* 125 3 */


            /*12422*/ //- /*12422*/
            
            int[] arrayNumbers=a.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
            int[] arrayNumbersRespaldo=arrayNumbers;
            int sizeArr=arrayNumbers.Length-1;
            
            bool esPosible=false;

            int counter=0;

            for (int i = (sizeArr-1); i >=0; i--)
            {
                if(arrayNumbers[i]<arrayNumbers[i+1])
                {
                    var temp=arrayNumbers[i];
                    arrayNumbers[i]=arrayNumbers[i+1];
                    arrayNumbers[i+1]=temp;
                    
                    counter=i;
                    esPosible=true;
                    break;
                }
            }

             int k, j;

            for (j=(counter+1); j<sizeArr; j++) {

                for (k=(counter+1); k<sizeArr; k++) {

                 if ( arrayNumbers[k] > arrayNumbers[k + 1])
                    {
                        var temp = arrayNumbers[k + 1];
                        arrayNumbers[k + 1] = arrayNumbers[k];
                        arrayNumbers[k] = temp;
                    }
                }
            }

            if(esPosible)
            {
                  int num;
                if (Int32.TryParse(string.Join("", arrayNumbers), out num))
                {
                    //success - handle the number
                    if(a<num)
                    {
                        return num;
                    }
                }
                else
                {
                    return -1;
                    //failed - too many digits in the array
                }
            }
            
            return -1;

        }
    }
}