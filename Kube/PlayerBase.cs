using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public abstract class PlayerBase
    {
        #region arrangment
        private bool _allowToReplay;
        public bool AllowToReplay
        {
            get { return _allowToReplay; }
            set { _allowToReplay = value; }
        }

        private int _allpoints;
        public int AllPoints
        {
            get { return _allpoints; }
            set { _allpoints = value; }
        }

        private Qube _qube;
        public Qube Qube
        {
            get { return _qube; }
            set { _qube = value; }
        }

        private int _localpoints;
        public int LocalPoints
        {
            get { return _localpoints; }
            set { _localpoints = value; }
        }
        #endregion

        /// <summary>
        /// Constructor with no parameters, sets base values
        /// </summary>
        public PlayerBase()
        {
            AllowToReplay = true;
            AllPoints = 0;
            LocalPoints = 0;
            Qube = new Qube();
        }
        
        /// <summary>
        /// Throw qube's number, set points
        /// </summary>
        public virtual void QubeThrow()
        {

        }

        /// <summary>
        /// End this player's turn, move to another player
        /// </summary>
        public virtual void EndTurn()
        {
            
        }
    }
}
