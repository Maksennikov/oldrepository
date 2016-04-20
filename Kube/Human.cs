using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Human: PlayerBase
    {
        /// <summary>
        /// AllPoints
        /// </summary>
        /// <param name="x"></param>
        public delegate void MethodStartEndTurn(int x, string n);
        public event MethodStartEndTurn OnEndTurn;

        public override void QubeThrow()
        {
            if (AllowToReplay)
            {
                Qube.SetNumber();

                if (Qube.Number > 1)
                {
                    LocalPoints += Qube.Number;
                }

                else
                {
                    LocalPoints = 0;
                    EndTurn();
                }
            }
        }

        public override void EndTurn()
        {
            AllPoints += LocalPoints;
            AllowToReplay = false;
            OnEndTurn(AllPoints, Name);
            LocalPoints = 0;
        }

        public void MyTime()
        {
            AllowToReplay = true;
        }
    }
}
