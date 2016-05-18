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
        public event MethodStartEndTurn OnEndTurnHuman;

        public delegate void MethodStartEndTurnForPC();
        public event MethodStartEndTurnForPC OnEndTurnHumanForPC;

        int kostil = 0;

        public override void QubeThrow()
        {
            if (kostil == 1)
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


            if (kostil == 0)
            {
                Qube.SetNumber();
                if (Qube.Number > 3)
                {
                    EndTurn();
                }
                kostil++;
            }
        }

        public override void EndTurn()
        {
            AllPoints += LocalPoints;
            AllowToReplay = false;
            OnEndTurnHuman(AllPoints, Name);
            OnEndTurnHumanForPC();
            LocalPoints = 0;
        }

        public void MyTime()
        {
            AllowToReplay = true;
        }
    }
}
