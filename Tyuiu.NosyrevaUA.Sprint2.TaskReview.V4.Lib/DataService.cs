using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NosyrevaUA.Sprint2.TaskReview.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x <= 0) && (y >= 0)) 
            {
                if (Math.Sqrt(x * x + y * y) <= 1)
                {
                    return true;
                }
                else { return false; }
            }
            else if ((x > 0) && (y >= 0))
            {
                if ((Math.Sqrt(x * x + y * y) <= 1) && (Math.Sqrt(x*x + y*y) >= 0.3))
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
             
        }
    }
}
