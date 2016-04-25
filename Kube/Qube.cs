using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Kube
{
    public class Qube : INotifyPropertyChanged
    {
       private int _number;
       public int Number
       {
           get { return _number; }
           set
            {
                _number = value;
                OnPropertyChanged("Number");
            }
       }

        /// <summary>
        /// Sets random number into the Number
        /// </summary>
        public void SetNumber()
       {
           Random rnd = new Random();
           Number = rnd.Next(1, 6);
           Number = Convert.ToInt16(Number);
       }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
