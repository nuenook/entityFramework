using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NORTHWNDEntities())
            {
                Application.EnableVisualStyles();
                Application.Run(new Interface());
            }
        }

        
    }


}
