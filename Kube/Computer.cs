using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Computer: PlayerBase
    {
        public delegate void MethodIAmDone();
        public event MethodIAmDone OnPCEndTurn;

        public override void QubeThrow()
        {
            Qube.SetNumber();
            AllPoints += Qube.Number;
        }

        public override void EndTurn()
        {
            OnPCEndTurn();
        }
    }
}
