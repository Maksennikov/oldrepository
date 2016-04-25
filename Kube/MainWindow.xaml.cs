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
        GameViewModel StartGame = new GameViewModel();
        

        public MainWindow()
        {
            InitializeComponent();
            StartGame.TheGame.OnEndGame += ShowWiner;

            MP.DataContext = StartGame.MainPLayer;
            ComputerPoints.DataContext = StartGame.Pc;

            CurrentPoints.DataContext = StartGame.MainPLayer.Qube;
        }

        public void ShowWiner(string name)
        {
            MessageBox.Show("And the winers is " + name);
        }

        private void DiceThrow_Click(object sender, RoutedEventArgs e)
        {
            StartGame.MainPLayer.QubeThrow();
        }

        private void EndTurnButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame.MainPLayer.EndTurn();
        }
    }
}
