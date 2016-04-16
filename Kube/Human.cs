using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Human: Player
    {
        public override void QubeThrow()
        {
            if (_aloudToReplay)
            {
                _QNumber.Next(1, 6);
                _Qube._number = Convert.ToInt16(_QNumber);
                if (_Qube._number > 1)
                {
                    _localpoints = _localpoints + _Qube._number;
                }
                else
                {
                    _localpoints = 0;
                    _aloudToReplay = false;
                }
            }
        }

        public override void EndTurn()
        {
            _allpoints = _allpoints + _localpoints;
            _localpoints = 0;
        }

        public void MyTime()
        {
            _aloudToReplay = true;
        }
    }
}
