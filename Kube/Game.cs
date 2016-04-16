using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Game
    {
        public delegate void MethodStartEndTurn();

        public event MethodStartEndTurn OnEndTurn;
        public void StartEndTurn()
        {
            OnEndTurn();
        }
    }
}
