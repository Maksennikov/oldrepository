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

        public delegate void MethodStartEndGame(string name);
        public event MethodStartEndGame OnEndGame;

        private int _winPoints;

        public Game()
        {
            _winPoints = 10;
        } 

        public void StartEndTurn(int points, string name)
        {
            if (PointCheck(points))
                OnEndGame(name);
            else
                OnEndTurn();
            
        }

        private bool PointCheck(int pointsTocheck)
        {
            if (pointsTocheck >= _winPoints)
                return true;
            else return false;

            
        }

        
    }
}
