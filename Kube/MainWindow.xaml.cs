using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kube
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Human _human = new Human();
        Game _game = new Game();
        Computer _pc = new Computer();
        public MainWindow()
        {

            InitializeComponent();
            _game.OnEndTurn += _human.EndTurn;
            _pc.OnPCEndTurn += _human.MyTime;


        }
    }
}
