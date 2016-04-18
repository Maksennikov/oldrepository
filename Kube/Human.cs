using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class Human: PlayerBase
    {
        public override void QubeThrow()
        {
            if (AllowToReplay)
            {
                //Присваивание кубу цифру убрал в сам куб
                Qube.SetNumber();

                if (Qube.Number > 1)
                {
                    LocalPoints += Qube.Number;
                }

                else
                {
                    //Если на кубе единица, то и в локальный счет нужно класть единицу, поправил
                    LocalPoints = 1;
                    AllowToReplay = false;
                }
            }
        }

        public override void EndTurn()
        {
            AllPoints += LocalPoints;
            LocalPoints = 0;
        }

        //сделать AllowToReplay протектедом, чтобы снаружи нельзя было до него добраться(подумать как)
        public void MyTime()
        {
            AllowToReplay = true;
        }
    }
}
