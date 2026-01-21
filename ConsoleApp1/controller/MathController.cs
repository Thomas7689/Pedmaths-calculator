using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class MathController
    {

        public double equationController(string eq)
        {
            double sum;

            calc e = new calc();
            sum = e.sumCalc(eq);

            return sum;
        }




    }
}
