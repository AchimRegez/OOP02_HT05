using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe02
{
    class Alert
    {
        //int NumberOfSeconds { get; set; }  
        //string Message { get; set; }

        public void CreateAlert(int NumberOfSeconds, string Message)
        {
            Console.WriteLine("{0} seconds passed", NumberOfSeconds);
        }
    }
}
