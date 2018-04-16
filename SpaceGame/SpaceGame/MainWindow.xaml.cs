using SpaceEnvironment;
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

namespace SpaceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PlayerSpaceship playerSpaceship = new PlayerSpaceship();

        public MainWindow()
        {
            InitializeComponent();

            var spaceDraw = new SpaceDraw(canvas);
            SpaceElement.DrawSpace(spaceDraw, 10, 10);

            playerSpaceship.Set(spaceDraw, 5, 9);
            playerSpaceship.DrawShip("./images/spaceship.gif");
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                playerSpaceship.Move(1);
            }

            if (e.Key == Key.Right)
            {
                playerSpaceship.Move(-1);
            }
        }
    }
}
