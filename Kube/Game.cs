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

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            _winPoints = 30;
        } 

        /// <summary>
        /// Switches game to the next step
        /// </summary>
        /// <param name="points">AllPoints</param>
        /// <param name="name">Name of the player</param>
        public void StartEndTurn(int points, string name)
        {
            if (PointCheck(points))
                OnEndGame(name);
            else
                OnEndTurn();            
        }

        /// <summary>
        /// Solves if win condition is done
        /// </summary>
        /// <param name="pointsTocheck">Points which will be checked</param>
        /// <returns></returns>
        private bool PointCheck(int pointsTocheck)
        {
            if (pointsTocheck >= _winPoints)
                return true;
            else
                return false;            
        }

        
    }
}
