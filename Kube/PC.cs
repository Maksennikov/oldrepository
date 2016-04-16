using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class PC: Player
    {
        public delegate void MethodIAmDone();

        public event MethodIAmDone OnPCEndTurn;
        public override void QubeThrow()
        {
            _QNumber.Next(1, 6);
            _Qube._number = Convert.ToInt16(_QNumber);
            _allpoints = _allpoints + _Qube._number;
            

        }
        public override void EndTurn()
        {
            OnPCEndTurn();
        }
    }
}
