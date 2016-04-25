using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kube
{
    public abstract class PlayerBase : INotifyPropertyChanged
    {

        #region arrangment
        
        private bool _allowToReplay;
        public bool AllowToReplay
        {
            get { return _allowToReplay; }
            set { _allowToReplay = value; }
        }

        protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _allpoints;
        public int AllPoints
        {
            get { return _allpoints; }
            set
            {
                _allpoints = value;
                OnPropertyChanged("AllPoints");
            }
        }

        private Qube _qube;
        public Qube Qube
        {
            get { return _qube; }
        }

        private int _localpoints;
        public int LocalPoints
        {
            get { return _localpoints; }
            set
            {
                _localpoints = value;
                OnPropertyChanged("LocalPoints");
            }
        }
        #endregion

        /// <summary>
        /// Constructor with no parameters, sets base values
        /// </summary>
        public PlayerBase()
        {
            AllowToReplay = true;
            LocalPoints = 0;
            _qube = new Qube();
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }
}
