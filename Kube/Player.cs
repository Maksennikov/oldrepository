using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    abstract class Player
    {
        public bool _aloudToReplay = true;
        public int _allpoints = 0;
        public Qube _Qube;
        public int _localpoints = 0;
        public Random _QNumber = new Random();
        
        

        public virtual void QubeThrow()
        {

        }

        public virtual void EndTurn()
        {
            
        }

        
    }
}
