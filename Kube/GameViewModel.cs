using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class GameViewModel
    {
        #region arrangment
        private Human _human;
        public Human MainPLayer
        {
            get { return _human; }
            set { _human = value; }
        }

        private Game _game;
        public Game TheGame
        {
            get { return _game; }
            set { _game = value; }
        }

        private Computer _pc;
        public Computer Pc
        {
            get { return _pc; }
            set { _pc = value; }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public GameViewModel()
        {
            MainPLayer = new Human();
            TheGame = new Game();
            Pc = new Computer();


            TheGame.OnEndTurn += _pc.QubeThrow;

            Pc.OnPCEndTurn += MainPLayer.MyTime;
            Pc.OnPCEndTurnForGame += TheGame.StartEndTurn;

            MainPLayer.OnEndTurn += TheGame.StartEndTurn;
        }
    }
}
