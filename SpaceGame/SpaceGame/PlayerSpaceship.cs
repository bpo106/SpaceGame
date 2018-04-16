using SpaceEnvironment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class PlayerSpaceship : Spaceship
    {

        public void Set (SpaceDraw spaceDraw, int x, int y)
        {
            Spaceship.spaceDraw = spaceDraw;
            posx = x;
            posy = y;
        }

        public void DrawShip(string filename)
        {
            spaceDraw.AddImage(filename, posx * 50, posy * 50);
        }

        public void Move(int x)
        {
            if (posx + x < 10 && posx + x >= 0)
            {
                spaceDraw.AddImage("./images/space.gif", posx * 50, posy * 50);
                posx += x;
                DrawShip("./images/spaceship.gif");
            }
        }
    }
}
