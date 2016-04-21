using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Qube
    {
       private int _number;
       public int Number
       {
           get { return _number; }
           set { _number = value; }
       }

       /// <summary>
       /// Sets random number to Number
       /// </summary>
       public void SetNumber()
       {
           Random rnd = new Random(6);
           _number = rnd.Next(1, 6);
           _number = Convert.ToInt16(Number);
       }
    }
}
