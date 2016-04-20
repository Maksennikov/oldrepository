using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public class GameViewModel
    {
        public Human _human;
        public Game _game;
        public Computer _pc;

        /// <summary>
        /// Constructor
        /// </summary>
        public GameViewModel()
        {
            _human = new Human();
            _game = new Game();
            _pc = new Computer();


            _game.OnEndTurn += _pc.QubeThrow;

            _pc.OnPCEndTurn += _human.MyTime;
            _pc.OnPCEndTurnForGame += _game.StartEndTurn;

            _human.OnEndTurn += _game.StartEndTurn;
        }
    }
}
