using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    internal class calc
    {


        public double sumCalc(string eq)
        {

            






            return 0;
        }

        public string bracket(string eq)
        {

            // Seperate the brackets into different arrays
            string[] br = eq.Split('(');
            //double[] brRes = new double[br.Length];
            int count = 0;

            foreach (var item in br)
            {
                br[count] = bracket(item);
                count++;
            }



            return null;
        }

        public double exponent(string exp)
        {
            //Seperate brackets and exponents
            exp.Replace(")", "");
            string[] e = exp.Split('^');

            char[] targets = { '+', '-' };

            int firstIndex = e[0].IndexOfAny(targets);

            if (firstIndex != -1)
            {
                char foundChar = e[0][firstIndex]; // Uses [] like charAt


                
            }




            return 0;
        }

        public double divide()
        {


            return 0;
        }

        public double multiply()
        {


            return 0;
        }

        public double addsubtract()
        {


            return 0;
        }


    }

}
