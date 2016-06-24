using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a new Console Application that displays the current time.  
In order to complete this task, you will need to find the documentation 
for the CoreFX DateTime structure. The main documentation for CoreFX is 
located here:

http://dotnet.github.io/api/index.html

And the documentation for DateTime can be found here:

http://dotnet.github.io/api/System.DateTime.html*/

namespace U4C1020CoreFXL1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            var timeNow = time.ToString();
            Console.WriteLine(timeNow);
            Console.ReadLine();
        }
    }
}
